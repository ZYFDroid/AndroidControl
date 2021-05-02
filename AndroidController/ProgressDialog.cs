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
    public partial class ProgressDialog : Form
    {
        public ProgressDialog()
        {
            InitializeComponent();
        }

        private void ProgressDialog_Load(object sender, EventArgs e)
        {
            new FormTranslator(this);
            backgroundWorker1.RunWorkerAsync();
        }

        public bool Run(Control parent) {
            if (parent != null)
            {
                this.StartPosition = FormStartPosition.Manual;
                this.Top = parent.Top + parent.Height / 2 - this.Height / 2;
                this.Left = parent.Left + parent.Width / 2 - this.Width / 2;
            }
            return ShowDialog(parent)==DialogResult.OK;
        }

        Action<BackgroundWorker> action;


        public static ProgressDialog Schedule(Action<BackgroundWorker> action) {
            return new ProgressDialog() { action = action };
        }


        private void ProgressDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = backgroundWorker1.IsBusy;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            System.Threading.Thread.Sleep(50);
            action.Invoke(backgroundWorker1);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Style = e.ProgressPercentage==0 ? ProgressBarStyle.Marquee : ProgressBarStyle.Continuous;
            if (e.ProgressPercentage != 0) {
                progressBar1.Value = e.ProgressPercentage;
            }
            if (e.UserState != null) {
                lblProgress.Text = e.UserState.ToString();
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DialogResult = button1.Enabled ? DialogResult.OK : DialogResult.Cancel;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            backgroundWorker1.CancelAsync();
        }
    }
}
