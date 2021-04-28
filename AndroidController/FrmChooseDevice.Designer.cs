
namespace AndroidController
{
    partial class FrmChooseDevice
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDevice = new System.Windows.Forms.ComboBox();
            this.tblOptions = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numResulution = new System.Windows.Forms.NumericUpDown();
            this.numFps = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numBitrate = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.chkTurnScreen = new System.Windows.Forms.CheckBox();
            this.chkWake = new System.Windows.Forms.CheckBox();
            this.chkOpenGL = new System.Windows.Forms.CheckBox();
            this.tblOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numResulution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBitrate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(259, 6);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(17, 20);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "+";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(282, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(56, 20);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Device:";
            // 
            // cmbDevice
            // 
            this.cmbDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDevice.FormattingEnabled = true;
            this.cmbDevice.Location = new System.Drawing.Point(65, 6);
            this.cmbDevice.Name = "cmbDevice";
            this.cmbDevice.Size = new System.Drawing.Size(188, 20);
            this.cmbDevice.TabIndex = 5;
            // 
            // tblOptions
            // 
            this.tblOptions.Controls.Add(this.label6);
            this.tblOptions.Controls.Add(this.numResulution);
            this.tblOptions.Controls.Add(this.numFps);
            this.tblOptions.Controls.Add(this.label3);
            this.tblOptions.Controls.Add(this.numBitrate);
            this.tblOptions.Controls.Add(this.label7);
            this.tblOptions.Controls.Add(this.label4);
            this.tblOptions.Controls.Add(this.label2);
            this.tblOptions.Controls.Add(this.btnStart);
            this.tblOptions.Controls.Add(this.chkTurnScreen);
            this.tblOptions.Controls.Add(this.chkOpenGL);
            this.tblOptions.Controls.Add(this.chkWake);
            this.tblOptions.Location = new System.Drawing.Point(14, 32);
            this.tblOptions.Name = "tblOptions";
            this.tblOptions.Size = new System.Drawing.Size(322, 183);
            this.tblOptions.TabIndex = 9;
            this.tblOptions.TabStop = false;
            this.tblOptions.Text = "Options";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "-1 for default.";
            // 
            // numResulution
            // 
            this.numResulution.Location = new System.Drawing.Point(227, 72);
            this.numResulution.Maximum = new decimal(new int[] {
            7680,
            0,
            0,
            0});
            this.numResulution.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numResulution.Name = "numResulution";
            this.numResulution.Size = new System.Drawing.Size(89, 21);
            this.numResulution.TabIndex = 12;
            // 
            // numFps
            // 
            this.numFps.Location = new System.Drawing.Point(51, 72);
            this.numFps.Maximum = new decimal(new int[] {
            320,
            0,
            0,
            0});
            this.numFps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numFps.Name = "numFps";
            this.numFps.Size = new System.Drawing.Size(86, 21);
            this.numFps.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Recommand 8Mbps for WLAN or 128Mbps for USB";
            // 
            // numBitrate
            // 
            this.numBitrate.Location = new System.Drawing.Point(104, 24);
            this.numBitrate.Maximum = new decimal(new int[] {
            320,
            0,
            0,
            0});
            this.numBitrate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numBitrate.Name = "numBitrate";
            this.numBitrate.Size = new System.Drawing.Size(111, 21);
            this.numBitrate.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(144, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "Screen width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "FPS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "Bitrate(Mbps):";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(6, 141);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(310, 36);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // chkTurnScreen
            // 
            this.chkTurnScreen.AutoSize = true;
            this.chkTurnScreen.Location = new System.Drawing.Point(161, 104);
            this.chkTurnScreen.Name = "chkTurnScreen";
            this.chkTurnScreen.Size = new System.Drawing.Size(114, 16);
            this.chkTurnScreen.TabIndex = 0;
            this.chkTurnScreen.Text = "Turn off screen";
            this.chkTurnScreen.UseVisualStyleBackColor = true;
            // 
            // chkWake
            // 
            this.chkWake.AutoSize = true;
            this.chkWake.Location = new System.Drawing.Point(17, 104);
            this.chkWake.Name = "chkWake";
            this.chkWake.Size = new System.Drawing.Size(120, 16);
            this.chkWake.TabIndex = 0;
            this.chkWake.Text = "Keep device wake";
            this.chkWake.UseVisualStyleBackColor = true;
            // 
            // chkOpenGL
            // 
            this.chkOpenGL.AutoSize = true;
            this.chkOpenGL.Location = new System.Drawing.Point(17, 122);
            this.chkOpenGL.Name = "chkOpenGL";
            this.chkOpenGL.Size = new System.Drawing.Size(240, 16);
            this.chkOpenGL.TabIndex = 0;
            this.chkOpenGL.Text = "Use OpenGL (may improve performance)";
            this.chkOpenGL.UseVisualStyleBackColor = true;
            // 
            // FrmChooseDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 227);
            this.Controls.Add(this.tblOptions);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDevice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChooseDevice";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Choose your device";
            this.Load += new System.EventHandler(this.FrmChooseDevice_Load);
            this.tblOptions.ResumeLayout(false);
            this.tblOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numResulution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBitrate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDevice;
        private System.Windows.Forms.GroupBox tblOptions;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox chkTurnScreen;
        private System.Windows.Forms.CheckBox chkWake;
        private System.Windows.Forms.NumericUpDown numBitrate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numFps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numResulution;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkOpenGL;
    }
}