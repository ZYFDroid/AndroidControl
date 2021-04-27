
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndroidController
{
    public partial class Form1 : Form
    {
        #region Win32
        [DllImport("user32.dll")]
        public static extern int SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        [DllImport("user32.dll", EntryPoint = "SetWindowLongA")]
        public static extern int SetWindowLong(IntPtr hwnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", EntryPoint = "GetWindowLongA")]
        public static extern int GetWindowLong(IntPtr hwnd, int nIndex);
        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        public static extern int SendMessage(IntPtr hwnd, uint wMsg, uint wParam, uint lParam);
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll")]
        public static extern int SetWindowPos(IntPtr hwnd, int hWndInsertAfter, int x, int y, int cx, int cy, int wFlags);
        public const int WS_VISIBLE = 0x10000000;
        public const int GWL_STYLE = -16;
        public const int SWP_SHOWWINDOW = 0x40;
        public const int SWP_FRAMECHANGED = 0x20;
        public const int SWP_NOACTIVATE = 0x10; 
        public const int WS_CHILDWINDOW = (WS_CHILD);
        public const int WS_CHILD = 0x40000000;
        public const int WS_CLIPCHILDREN = 0x2000000;
        private const int GWL_EXSTYLE = -20;
        private const int WS_EX_CONTROLPARENT = 0x10000;

        [DllImport("user32.dll")]
        public static extern int SetForegroundWindow(IntPtr hwnd);

        #endregion


        public Process prcScrcpy = null;
        IntPtr hwndScrcpy = IntPtr.Zero;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.phone;
        }

        private void btnColPanel_Click(object sender, EventArgs e)
        {
            if (panBottom.Height == btnColPanel.Height)
            {
                panBottom.Height = int.Parse(panBottom.Tag.ToString());
                tableLayoutPanel1.Visible = true;
            }
            else {
                panBottom.Height = btnColPanel.Height;
                tableLayoutPanel1.Visible = false;
            }
        }

        string DefaultScrcpyArgs  { 
            get {
                String args = "--window-title " + Program.defaultWindowName + " --rotation 0 --forward-all-clicks --shortcut-mod=lctrl+lsuper ";
                if (Program.Settings.SCCloseScreen) {args += "-S ";}
                if (Program.Settings.SCKeepWake) { args += "-w "; }
                if (Program.Settings.SCMbps > 0)
                {
                    args += "--bit-rate " + Program.Settings.SCMbps + "M ";
                }

                if (Program.Settings.SCFps > 0)
                {
                    args += "--max-fps " + Program.Settings.SCFps + " ";
                }

                if (Program.Settings.SCResolution > 0)
                {
                    args += "--max-size " + Program.Settings.SCResolution + " ";
                }
                return args;
            } 
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (prcScrcpy != null)
            {
                stopScrcpy();
            }
            else {
                showDialogInCenter(new FrmChooseDevice(this));
            }
        }

        public void stopScrcpy() {
            try
            {
                prcScrcpy.CloseMainWindow();
            }
            catch { }
            try
            {
                prcScrcpy.Kill();
            }
            catch { }
            prcScrcpy = null;
            hwndScrcpy = IntPtr.Zero;
            lblPlaceholder.Visible = true;
            btnConnect.BackgroundImage = Properties.Resources.btn_add;
        }

        public void startScrcpy(string deviceseries) {
            ProgressDialog.Schedule(x =>
            {
                x.ReportProgress(0, "Connecting to device... ");
                ProcessStartInfo psi = new ProcessStartInfo("scrcpy.exe", DefaultScrcpyArgs + "--serial " + deviceseries);
                psi.RedirectStandardError = true;
                psi.RedirectStandardOutput = true;
                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;
                psi.EnvironmentVariables.Add("ADB", Program.AdbClient.adbPath);
                prcScrcpy = Process.Start(psi);
                prcScrcpy.Exited += PrcScrcpy_Exited;
                prcScrcpy.OutputDataReceived += PrcScrcpy_OutputDataReceived;
                prcScrcpy.ErrorDataReceived += PrcScrcpy_OutputDataReceived;
                prcScrcpy.BeginErrorReadLine();
                prcScrcpy.BeginOutputReadLine();
                while (hwndScrcpy == IntPtr.Zero)
                {
                    hwndScrcpy = FindWindow(null, Program.defaultWindowName);
                    Thread.Sleep(2);
                    if (prcScrcpy.HasExited)
                    {
                        x.ReportProgress(100, "Connection Failed. Press [Cancel] to close.");
                        while (!x.CancellationPending)
                        {
                            System.Threading.Thread.Sleep(100);
                        }
                        prcScrcpy = null;
                        hwndScrcpy = IntPtr.Zero;
                        return;
                    }
                }
               
                Invoke(new Action(() =>
                {
                    lblPlaceholder.Visible = false;
                    SetWindowLong(hwndScrcpy, GWL_STYLE, WS_VISIBLE | WS_CLIPCHILDREN);
                    int temp = GetWindowLong(panMain.Handle, GWL_EXSTYLE);
                    temp = temp & (~WS_EX_CONTROLPARENT);
                    SetWindowLong(panMain.Handle, GWL_EXSTYLE, temp);

                    temp = GetWindowLong(this.Handle, GWL_EXSTYLE);
                    temp = temp & (~WS_EX_CONTROLPARENT);
                    SetWindowLong(this.Handle, GWL_EXSTYLE, temp);

                    SetParent(hwndScrcpy, panMain.Handle);
                    SetWindowPos(hwndScrcpy, 0, 0, 0, panMain.Width-5, panMain.Height-5, SWP_SHOWWINDOW | SWP_FRAMECHANGED);
                }));
                Thread.Sleep(333);
            }).Run(this);
            if (prcScrcpy != null) {
                btnConnect.BackgroundImage = Properties.Resources.BtnDisconnect;
                SetWindowPos(hwndScrcpy, 0, 0, 0, panMain.Width, panMain.Height , SWP_SHOWWINDOW | SWP_FRAMECHANGED);
            }
        }

        public DeviceInfo device;

        private void PrcScrcpy_Exited(object sender, EventArgs e)
        {
            prcScrcpy = null;
            hwndScrcpy = IntPtr.Zero;
            lblPlaceholder.Visible = true;
            btnConnect.BackgroundImage = Properties.Resources.btn_add;
        }

        private void PrcScrcpy_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            Console.WriteLine(e.Data);
            if (hwndScrcpy != IntPtr.Zero)
            {
                SetWindowPos(hwndScrcpy, 0, 0, 0, panMain.Width, panMain.Height, SWP_SHOWWINDOW | SWP_FRAMECHANGED | SWP_NOACTIVATE);
            }
        }

        private void panMain_SizeChanged(object sender, EventArgs e)
        {
            if(hwndScrcpy != IntPtr.Zero)
            {
                SetWindowPos(hwndScrcpy, 0, 0, 0, panMain.Width, panMain.Height, SWP_SHOWWINDOW | SWP_FRAMECHANGED | SWP_NOACTIVATE);
            }
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (device != null && !backgroundWorker1.IsBusy) {
                backgroundWorker1.RunWorkerAsync(((Control)sender).Tag);
            }
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            showInCenter(new FrmAudioForwarding());
        }

        public void showInCenter(Form f) {
            f.StartPosition = FormStartPosition.Manual;
            f.Top =this.Top+ this.Height / 2 - f.Height / 2;
            f.Left =this.Left + this.Width / 2 - f.Width / 2;
            f.Show(this);
        }
        public void showDialogInCenter(Form f)
        {
            f.StartPosition = FormStartPosition.Manual;
            f.Top = this.Top + this.Height / 2 - f.Height / 2;
            f.Left = this.Left + this.Width / 2 - f.Width / 2;
            f.ShowDialog(this);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (prcScrcpy != null)
            {
                stopScrcpy();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Program.AdbClient.runDeviceCommand(device, "shell input keyevent " + e.Argument.ToString());
        }
    }
}
