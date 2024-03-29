﻿
namespace AndroidController
{
    partial class FrmAudioForwarding
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbDevice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panFunctions = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnServer = new System.Windows.Forms.Button();
            this.btnInstall = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnForwarding = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.panFunctions.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbDevice
            // 
            this.cmbDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDevice.FormattingEnabled = true;
            this.cmbDevice.Location = new System.Drawing.Point(79, 12);
            this.cmbDevice.Name = "cmbDevice";
            this.cmbDevice.Size = new System.Drawing.Size(174, 20);
            this.cmbDevice.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "DeviceM";
            // 
            // panFunctions
            // 
            this.panFunctions.Controls.Add(this.label3);
            this.panFunctions.Controls.Add(this.label4);
            this.panFunctions.Controls.Add(this.label5);
            this.panFunctions.Controls.Add(this.label2);
            this.panFunctions.Controls.Add(this.btnServer);
            this.panFunctions.Controls.Add(this.btnInstall);
            this.panFunctions.Controls.Add(this.btnStop);
            this.panFunctions.Controls.Add(this.btnForwarding);
            this.panFunctions.Location = new System.Drawing.Point(14, 38);
            this.panFunctions.Name = "panFunctions";
            this.panFunctions.Size = new System.Drawing.Size(324, 214);
            this.panFunctions.TabIndex = 2;
            this.panFunctions.TabStop = false;
            this.panFunctions.Text = "Actions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "AudioStep2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "StopAudioDesc";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(312, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "AudioWarrenty";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "AudioStep1";
            // 
            // btnServer
            // 
            this.btnServer.Location = new System.Drawing.Point(6, 55);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(139, 29);
            this.btnServer.TabIndex = 4;
            this.btnServer.Text = "StartServer";
            this.btnServer.UseVisualStyleBackColor = true;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // btnInstall
            // 
            this.btnInstall.Location = new System.Drawing.Point(6, 20);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(139, 29);
            this.btnInstall.TabIndex = 4;
            this.btnInstall.Text = "InstallSoftware";
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(6, 90);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(139, 28);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "StopAudio";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnForwarding
            // 
            this.btnForwarding.Location = new System.Drawing.Point(6, 160);
            this.btnForwarding.Name = "btnForwarding";
            this.btnForwarding.Size = new System.Drawing.Size(312, 45);
            this.btnForwarding.TabIndex = 3;
            this.btnForwarding.Text = "StartForwarding";
            this.btnForwarding.UseVisualStyleBackColor = true;
            this.btnForwarding.Click += new System.EventHandler(this.btnForwarding_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(282, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(56, 20);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(259, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(17, 20);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Plus";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // FrmAudioForwarding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 262);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.panFunctions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDevice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAudioForwarding";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AudioForward";
            this.Load += new System.EventHandler(this.FrmAudioForwarding_Load);
            this.panFunctions.ResumeLayout(false);
            this.panFunctions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDevice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox panFunctions;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnForwarding;
        private System.Windows.Forms.Button btnServer;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnConnect;
    }
}