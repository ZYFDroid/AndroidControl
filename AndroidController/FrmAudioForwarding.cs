using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndroidController
{
    public partial class FrmAudioForwarding : Form
    {
        public FrmAudioForwarding()
        {
            InitializeComponent();
        }

        private void FrmAudioForwarding_Load(object sender, EventArgs e)
        {
            new FormTranslator(this);
            btnRefresh.PerformClick();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cmbDevice.setDict(Program.AdbClient.getDeviceList().ToDictionary(d => $"{d.TransportId}:{d.Model}({d.DeviceSeries})"));
            panFunctions.Enabled = cmbDevice.Enabled;
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            DeviceInfo dev = cmbDevice.SelectedValue as DeviceInfo;
            ProgressDialog.Schedule(x =>
            {
                x.ReportProgress(0,"InstallingSoftware".t());
                Program.AdbClient.runDeviceCommand(dev, "install -g -r sndcpy.apk");
            }).Run(this);
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            DeviceInfo dev = cmbDevice.SelectedValue as DeviceInfo;
            ProgressDialog.Schedule(x =>
            {
                x.ReportProgress(0, "StartAudioServer".t());
                Program.AdbClient.runDeviceCommand(dev, "shell am force-stop com.rom1v.sndcpy");
                Program.AdbClient.runDeviceCommand(dev, "shell am start com.rom1v.sndcpy/.MainActivity");
                x.ReportProgress(0,"PressStartHint".t());
                System.Threading.Thread.Sleep(667);
            }).Run(this);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ProgressDialog.Schedule(x =>
            {
                Process.GetProcessesByName("sndcpy_audioreceiver").ToList().ForEach(f => {
                    try
                    {
                        f.Kill();
                    }
                    catch (Exception ex) {
                        Console.WriteLine(ex.ToString());
                    }
                });
            }).Run(this);
        }

        private void btnForwarding_Click(object sender, EventArgs e)
        {
            DeviceInfo dev = cmbDevice.SelectedValue as DeviceInfo;
            ProgressDialog.Schedule(x =>
            {
                Process.GetProcessesByName("sndcpy_audioreceiver").ToList().ForEach(f => {
                    try
                    {
                        f.Kill();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                });
                x.ReportProgress(0, "Connecting".t());
                Program.AdbClient.runDeviceCommand(dev, $"forward tcp:{Program.Settings.SCSndPort} localabstract:sndcpy");
                System.Threading.Thread.Sleep(1000);
                ProcessStartInfo psi = new ProcessStartInfo("sndcpy_audioreceiver.exe");
                psi.UseShellExecute = false;
                psi.RedirectStandardOutput = true;
                psi.CreateNoWindow = true;
                x.ReportProgress(0, "StartingAudio".t());
                Process ps = Process.Start(psi);
                ps.BeginOutputReadLine();

                bool success = false;
                bool fail = false;
                DataReceivedEventHandler d = new DataReceivedEventHandler((a, b) =>
                {
                    if (b.Data.Contains("ERR") || b.Data.Contains("STOPPED"))
                    {
                        fail = true;
                    }
                    if (b.Data.Contains("SUCCESS"))
                    {
                        success = true;
                    }
                });
                ps.OutputDataReceived += d;
                System.Threading.Thread.Sleep(1000);


                for (int i = 1; i <= 8; i++)
                {
                    x.ReportProgress(0, "CheckConnection".t()+i);
                    System.Threading.Thread.Sleep(1000);
                    if (ps.HasExited || fail)
                    {
                        x.ReportProgress(100, "ConnectFailPressCancel".t());
                        while (!x.CancellationPending)
                        {
                            System.Threading.Thread.Sleep(100);
                        }
                        ps.OutputDataReceived -= d;
                        return;
                    }
                    else {
                        if (success) {

                            ps.OutputDataReceived -= d;
                            return;
                        }
                    }
                    if (x.CancellationPending) {

                        ps.OutputDataReceived -= d;
                        return;
                    }
                }

            }).Run(this);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            FrmConnectDevice f = new FrmConnectDevice();
            f.StartPosition = FormStartPosition.Manual;
            f.Top = this.Top + this.Height / 2 - f.Height / 2;
            f.Left = this.Left + this.Width / 2 - f.Width / 2;
            f.Show(this);
            f.FormClosed += F_FormClosed;
        }

        private void F_FormClosed(object sender, FormClosedEventArgs e)
        {
            cmbDevice.setDict(Program.AdbClient.getDeviceList().ToDictionary(d => $"{d.TransportId}:{d.Model}({d.DeviceSeries})"));
            panFunctions.Enabled = cmbDevice.Enabled;
        }
    }
}
