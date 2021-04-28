using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndroidController
{
    public partial class FrmConnectDevice : Form
    {
        string deviceHistory = "deviceHistory.txt";
        public FrmConnectDevice()
        {
            InitializeComponent();
        }

        private void FrmConnectDevice_Load(object sender, EventArgs e)
        {
            loadData();
        }

        List<DeviceInfo> devInfos = new List<DeviceInfo>();

        public void loadData() {
            tblDeviceList.Rows.Clear();
            devInfos.Clear();
            ProgressDialog.Schedule(x =>
            {
                devInfos.AddRange(Program.AdbClient.getDeviceList());
                if (File.Exists(deviceHistory)) {
                    devInfos.AddRange(File.ReadAllLines(deviceHistory).Distinct().Where(d => d.Trim() != "")
                        .Where(d=> !devInfos.Any(f => f.DeviceSeries==d || f.DeviceSeries==d+":5555"))
                        .Select(d => new DeviceInfo("", d.Trim()) {Model="",Device="" }));
                }
            }).Run(this);
            devInfos.ForEach(d =>
            {
                string no = (tblDeviceList.RowCount + 1) + "";
                string device = d.Device;
                string model = d.Model;
                string series = d.DeviceSeries;
                Image connected = d.TransportId == "-1" ? Properties.Resources.fail : Properties.Resources.ok;
                Image action1 = d.TransportId == "-1" ? Properties.Resources.connect : Properties.Resources.btn_add;
                Image action2 = d.TransportId == "-1" ? Properties.Resources.remove : Properties.Resources.btn_add;
                tblDeviceList.Rows.Add(d, no, model, device, series, connected, action1, action2);
            });
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (txtIp.Text.Trim() != "") {
                string devname = txtIp.Text.Trim().Replace(" ", "");
                List<string> devs = new List<string>(); if (File.Exists(deviceHistory)) { devs.AddRange(File.ReadAllLines(deviceHistory)); }
                if (!devs.Contains(devname)) {
                    devs.Add(devname);
                    File.WriteAllLines(deviceHistory, devs.ToArray());
                }
                loadData();
            }
        }

        private void tblDeviceList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {
                DeviceInfo din = tblDeviceList[0, e.RowIndex].Value as DeviceInfo;
                bool connected = din.TransportId != "-1";
                if (!connected)
                {
                    if (e.ColumnIndex == 6)
                    {
                        ProgressDialog.Schedule(x =>
                        {
                            x.ReportProgress(0, "Connecting to device...");
                            string result = Program.AdbClient.runRawCommand("connect " + din.DeviceSeries, true);
                        }).Run(this);
                        loadData();
                    }
                    if (e.ColumnIndex == 7)
                    {
                        List<string> devs = new List<string>(); if (File.Exists(deviceHistory)) { devs.AddRange(File.ReadAllLines(deviceHistory)); }
                        if (devs.Contains(din.DeviceSeries))
                        {
                            devs.Remove(din.DeviceSeries);
                            File.WriteAllLines(deviceHistory, devs.ToArray());
                            loadData();
                        }
                    }
                }
                
            }
        }
    }
}
