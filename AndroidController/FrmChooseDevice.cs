using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndroidController
{
    public partial class FrmChooseDevice : Form
    {
        Form1 parent;

        public FrmChooseDevice(Form1 parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cmbDevice.setDict(Program.AdbClient.getDeviceList().ToDictionary(d => $"{d.TransportId}:{d.Model}({d.DeviceSeries})"));
            tblOptions.Enabled = cmbDevice.Enabled;
        }

        private void FrmChooseDevice_Load(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
            numBitrate.Value = Program.Settings.SCMbps;
            numResulution.Value = Program.Settings.SCResolution;
            numFps.Value = Program.Settings.SCFps;
            chkTurnScreen.Checked = Program.Settings.SCCloseScreen;
            chkWake.Checked = Program.Settings.SCKeepWake;
            chkOpenGL.Checked = Program.Settings.SCUseOpenGL;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            DeviceInfo device = cmbDevice.SelectedValue as DeviceInfo;
            parent.device = device;

            Program.Settings.SCMbps = (int)numBitrate.Value;
            Program.Settings.SCResolution= (int)numResulution.Value ;
             Program.Settings.SCFps= (int)numFps.Value ;
            Program.Settings.SCCloseScreen= chkTurnScreen.Checked ;
             Program.Settings.SCKeepWake= chkWake.Checked ;
            Program.Settings.SCUseOpenGL = chkOpenGL.Checked;
            Close();
            parent.BeginInvoke(new Action(() => {
                parent.startScrcpy(device.DeviceSeries);
            }));
        }
    }
}
