using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AndroidController
{
    static class Program
    {
        public static string defaultWindowName = "WINDOWBYCS9925834";
        public static AdbClient AdbClient = new AdbClient();
        public static Properties.Settings Settings = Properties.Settings.Default;
        [STAThread]
        static void Main()
        {
            
            Environment.CurrentDirectory =Path.Combine(Path.GetDirectoryName(Application.ExecutablePath),"tools");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AdbClient.adbPath = getAdbPath();
            Translator.init();
            Translator.chLang(Translator.SystemLanguage);
            Console.Write("");
            Application.Run(ProgressDialog.Schedule(e =>
            {
                e.ReportProgress(0, "StartingADB".t());
                AdbClient.ensureAdbRunning();
                var a = AdbClient.getDeviceList();
            }));
            

            Application.Run(new Form1());
            Settings.Save();
        }

        public static string getAdbPath() {
            foreach (Process item in Process.GetProcessesByName("adb"))
            {
                return item.MainModule.FileName;
            }
            foreach (string item in Environment.GetEnvironmentVariable("PATH").Split(Path.PathSeparator))
            {
                if (File.Exists(Path.Combine(item, "adb.exe"))) {
                    return Path.Combine(item, "adb.exe");
                }
            }
            return "adb.exe";
        }
        public static void setDict<T>(this ComboBox cmb, Dictionary<String, T> dict)
        {
            cmb.Enabled = false;
            cmb.DataSource = null;
            cmb.Items.Clear();
            cmb.Text = null;
            if (dict != null && dict.Count > 0)
            {
                cmb.Enabled = true;
                cmb.DataSource = new BindingSource() { DataSource = dict };
                cmb.DisplayMember = "Key";
                cmb.ValueMember = "Value";
            }
        }
        

    
    }


    public static class Translator
    {
        public static Dictionary<String, String> baseTran = new Dictionary<string, string>();
        public static Dictionary<String, String> overTran = new Dictionary<string, string>();
        public static Dictionary<String, String> langList = new Dictionary<string, string>();

        public static string SystemLanguage {
            get {
                return System.Threading.Thread.CurrentThread.CurrentCulture.Name.ToLower().Replace("-", "_");
            }
        }

        public static void init()
        {
            Directory.EnumerateFiles("languages", "*.xml").ToList().ForEach(f => {
                try
                {
                    loadLang(f, baseTran);
                    langList.Add(XDocument.Load(f).Root.Attribute("name").Value, f);
                }
                catch { }
            });
            loadLang(langList["default"], baseTran);
        }

        public static void chLang(String langName)
        {
            if (langList.ContainsKey(langName))
            {
                loadLang(langList[langName], overTran);
            }
        }

        public static void loadLang(String fn, Dictionary<String, String> dict)
        {
            dict.Clear();
            XDocument.Load(fn).Root.Elements().ToList().ForEach(el => {
                dict.Remove(el.Name.LocalName);
                dict.Add(el.Name.LocalName, el.Value);
            });
        }

        public static String t(this String s)
        {
            if (s == null || s == "") { return s; }
            if (overTran.ContainsKey(s)) { return overTran[s]; }
            if (baseTran.ContainsKey(s)) { return baseTran[s]; }
            return "?" + s + "<";
        }
    }

    public class FormTranslator {
        Form form;

        public FormTranslator(Form form)
        {
            this.form = form;
            doScan(form);
            TranslateAll();
        }


        public void doScan(Control ctl)
        {
            if (ctl is NumericUpDown || ctl is ComboBox || ctl is DateTimePicker)
            {
                return;
            }
            if (ctl is TextBox) {
                TextBox t = ctl as TextBox;
                if (t.ReadOnly) {
                    t.ReadOnly = false;
                    t.Text = t.Text.t();
                    t.ReadOnly = true;
                }
                return;
            }
            if (ctl is DataGridView)
            {
                foreach (DataGridViewColumn col in (ctl as DataGridView).Columns)
                {
                    tranObjs.Add(new TransObj(col, "HeaderText"));
                }
                return;
            }
            tranObjs.Add(new TransObj(ctl, "Text"));
            foreach (Control c in ctl.Controls)
            {
                doScan(c);
            }
        }
        public void TranslateAll() => tranObjs.ForEach(s => s.Translate());
        List<TransObj> tranObjs = new List<TransObj>();
        public class TransObj
        {
            String key;
            object obj;
            String prop;

            public TransObj(object obj, string prop)
            {
                this.obj = obj;
                this.prop = prop;
                key = obj.GetType().GetProperty(prop).GetValue(obj).ToString();
            }
            public void Translate()
            {
                obj.GetType().GetProperty(prop).SetValue(obj, key.t());
            }
        }

    }

    public class AdbClient {
        public String adbPath = "adb.exe";

        public void ensureAdbRunning() {
            Console.WriteLine(runRawCommand("devices"));
        }

        public string runRawCommand(string cmd, bool includeErr = false) {
            ProcessStartInfo psi = new ProcessStartInfo(adbPath, cmd);
            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            Process adbp = Process.Start(psi);
            adbp.WaitForExit();
            StreamReader sr = (adbp.StandardOutput);
            StreamReader sr2 =(adbp.StandardError);
            string result = "";
            result += sr.ReadToEnd();
            string err = sr2.ReadToEnd();
            if (err.Trim() != "" && includeErr) { 
                result+="\r\n"+err;
            }
            Console.WriteLine(result);
            sr.Close();
            sr2.Close();
            return result;
        }

        public List<DeviceInfo> getDeviceList() {
            return runRawCommand("devices -l")
                .Split('\r', '\n')
                .Where(l => l.Contains("model"))
                .Select(t => splitAdbResult(t))
                .Select(t => new DeviceInfo(t[1],t[0]))
                .ToList();
        }

        private string[] splitAdbResult(string raw) {
            int idx = raw.IndexOf(' ');
            string str1 = raw.Substring(0, idx);
            string str2 = raw.Substring(idx, raw.Length - idx);
            return new string[] {str1,str2 };
        }

        public string runDeviceCommand(DeviceInfo dev, string command, bool includeErr = false) {
            if (dev == null) {
                return runRawCommand($"{command}", includeErr);
            }
            return runRawCommand($"-t {dev.TransportId} {command}", includeErr);
        }
    }

    public class DeviceInfo
    {
        public string DeviceData;
        public string DeviceSeries;
        public string Product = "Android Device";
        public string Model = "Android Device";
        public string Device = "Android Device";
        public string TransportId = "-1";
        public DeviceInfo(string deviceName, string deviceSeries)
        {
            DeviceData = deviceName;
            DeviceSeries = deviceSeries;
            DeviceData.Split(' ').Where(d => d.Contains(":")).Select(d => d.Split(':')).ToList().ForEach(d =>
            {
                if (d[0] == "product") { Product = d[1]; }
                if (d[0] == "model") { Model = d[1]; }
                if (d[0] == "device") { Device = d[1]; }
                if (d[0] == "transport_id") { TransportId = d[1]; }
            });
        }
    }
}
