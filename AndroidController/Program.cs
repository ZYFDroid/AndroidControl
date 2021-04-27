using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Application.Run(ProgressDialog.Schedule(e =>
            {
                e.ReportProgress(0, "Starting ADB server...");
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
        public string TransportId = "0";
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
