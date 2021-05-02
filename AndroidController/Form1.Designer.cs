
namespace AndroidController
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panBottom = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDock = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnSound = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnTask = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnColPanel = new System.Windows.Forms.Label();
            this.panMain = new System.Windows.Forms.Panel();
            this.lblPlaceholder = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mnuDockOn = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dockLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dockRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDockOff = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitDockModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dockTimer = new System.Windows.Forms.Timer(this.components);
            this.dockAnimTimer = new System.Windows.Forms.Timer(this.components);
            this.chkPin = new System.Windows.Forms.ToolStripMenuItem();
            this.panBottom.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panMain.SuspendLayout();
            this.mnuDockOn.SuspendLayout();
            this.mnuDockOff.SuspendLayout();
            this.SuspendLayout();
            // 
            // panBottom
            // 
            this.panBottom.BackColor = System.Drawing.Color.Black;
            this.panBottom.Controls.Add(this.tableLayoutPanel1);
            this.panBottom.Controls.Add(this.btnColPanel);
            this.panBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBottom.Location = new System.Drawing.Point(0, 717);
            this.panBottom.Name = "panBottom";
            this.panBottom.Size = new System.Drawing.Size(411, 60);
            this.panBottom.TabIndex = 2;
            this.panBottom.Tag = "60";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.49941F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.49942F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.49942F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.49942F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.49999F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.49942F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.49942F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.50352F));
            this.tableLayoutPanel1.Controls.Add(this.btnDock, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnConnect, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSound, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSetting, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMenu, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnTask, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnHome, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBack, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(411, 48);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnDock
            // 
            this.btnDock.BackgroundImage = global::AndroidController.Properties.Resources.dock;
            this.btnDock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDock.FlatAppearance.BorderSize = 0;
            this.btnDock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnDock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDock.Location = new System.Drawing.Point(207, 3);
            this.btnDock.Name = "btnDock";
            this.btnDock.Size = new System.Drawing.Size(45, 42);
            this.btnDock.TabIndex = 7;
            this.btnDock.UseVisualStyleBackColor = true;
            this.btnDock.Click += new System.EventHandler(this.btnDock_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackgroundImage = global::AndroidController.Properties.Resources.btn_add;
            this.btnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConnect.FlatAppearance.BorderSize = 0;
            this.btnConnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Location = new System.Drawing.Point(360, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(48, 42);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnSound
            // 
            this.btnSound.BackgroundImage = global::AndroidController.Properties.Resources.sound;
            this.btnSound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSound.FlatAppearance.BorderSize = 0;
            this.btnSound.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnSound.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSound.Location = new System.Drawing.Point(309, 3);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(45, 42);
            this.btnSound.TabIndex = 4;
            this.btnSound.UseVisualStyleBackColor = true;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackgroundImage = global::AndroidController.Properties.Resources.BtnSetting;
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Location = new System.Drawing.Point(258, 3);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(45, 42);
            this.btnSetting.TabIndex = 5;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackgroundImage = global::AndroidController.Properties.Resources.BtnMenu;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Location = new System.Drawing.Point(156, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(45, 42);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.Tag = "KEYCODE_MENU";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnTask
            // 
            this.btnTask.BackgroundImage = global::AndroidController.Properties.Resources.BtnTask;
            this.btnTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTask.FlatAppearance.BorderSize = 0;
            this.btnTask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTask.Location = new System.Drawing.Point(105, 3);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(45, 42);
            this.btnTask.TabIndex = 2;
            this.btnTask.Tag = "KEYCODE_APP_SWITCH";
            this.btnTask.UseVisualStyleBackColor = true;
            this.btnTask.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = global::AndroidController.Properties.Resources.BtnHome;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(54, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(45, 42);
            this.btnHome.TabIndex = 1;
            this.btnHome.Tag = "KEYCODE_HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::AndroidController.Properties.Resources.BtnBack;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(45, 42);
            this.btnBack.TabIndex = 0;
            this.btnBack.Tag = "KEYCODE_BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnColPanel
            // 
            this.btnColPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnColPanel.ForeColor = System.Drawing.Color.White;
            this.btnColPanel.Location = new System.Drawing.Point(0, 0);
            this.btnColPanel.Name = "btnColPanel";
            this.btnColPanel.Size = new System.Drawing.Size(411, 12);
            this.btnColPanel.TabIndex = 0;
            this.btnColPanel.Text = "ExpandHandle";
            this.btnColPanel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnColPanel.Click += new System.EventHandler(this.btnColPanel_Click);
            // 
            // panMain
            // 
            this.panMain.BackColor = System.Drawing.Color.Black;
            this.panMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panMain.Controls.Add(this.lblPlaceholder);
            this.panMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMain.Location = new System.Drawing.Point(0, 0);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(411, 717);
            this.panMain.TabIndex = 1;
            this.panMain.SizeChanged += new System.EventHandler(this.panMain_SizeChanged);
            // 
            // lblPlaceholder
            // 
            this.lblPlaceholder.BackColor = System.Drawing.Color.White;
            this.lblPlaceholder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlaceholder.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaceholder.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblPlaceholder.Location = new System.Drawing.Point(0, 0);
            this.lblPlaceholder.Name = "lblPlaceholder";
            this.lblPlaceholder.Size = new System.Drawing.Size(411, 717);
            this.lblPlaceholder.TabIndex = 0;
            this.lblPlaceholder.Text = "NoDev";
            this.lblPlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.BackColor = System.Drawing.Color.White;
            this.toolTip1.ForeColor = System.Drawing.Color.Black;
            this.toolTip1.InitialDelay = 800;
            this.toolTip1.ReshowDelay = 100;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // mnuDockOn
            // 
            this.mnuDockOn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dockLeftToolStripMenuItem,
            this.dockRightToolStripMenuItem});
            this.mnuDockOn.Name = "mnuDockOn";
            this.mnuDockOn.Size = new System.Drawing.Size(137, 48);
            // 
            // dockLeftToolStripMenuItem
            // 
            this.dockLeftToolStripMenuItem.Name = "dockLeftToolStripMenuItem";
            this.dockLeftToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.dockLeftToolStripMenuItem.Text = "DockLeft";
            this.dockLeftToolStripMenuItem.Click += new System.EventHandler(this.dockLeftToolStripMenuItem_Click);
            // 
            // dockRightToolStripMenuItem
            // 
            this.dockRightToolStripMenuItem.Name = "dockRightToolStripMenuItem";
            this.dockRightToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.dockRightToolStripMenuItem.Text = "DockRight";
            this.dockRightToolStripMenuItem.Click += new System.EventHandler(this.dockRightToolStripMenuItem_Click);
            // 
            // mnuDockOff
            // 
            this.mnuDockOff.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chkPin,
            this.exitDockModeToolStripMenuItem});
            this.mnuDockOff.Name = "mnuDockOff";
            this.mnuDockOff.Size = new System.Drawing.Size(181, 70);
            // 
            // exitDockModeToolStripMenuItem
            // 
            this.exitDockModeToolStripMenuItem.Name = "exitDockModeToolStripMenuItem";
            this.exitDockModeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitDockModeToolStripMenuItem.Text = "DockClose";
            this.exitDockModeToolStripMenuItem.Click += new System.EventHandler(this.exitDockModeToolStripMenuItem_Click);
            // 
            // dockTimer
            // 
            this.dockTimer.Interval = 333;
            this.dockTimer.Tick += new System.EventHandler(this.dockTimer_Tick);
            // 
            // dockAnimTimer
            // 
            this.dockAnimTimer.Interval = 1;
            this.dockAnimTimer.Tick += new System.EventHandler(this.dockAnimTimer_Tick);
            // 
            // chkPin
            // 
            this.chkPin.CheckOnClick = true;
            this.chkPin.Name = "chkPin";
            this.chkPin.Size = new System.Drawing.Size(180, 22);
            this.chkPin.Text = "Pin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(411, 777);
            this.Controls.Add(this.panMain);
            this.Controls.Add(this.panBottom);
            this.MinimumSize = new System.Drawing.Size(260, 400);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.panBottom.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panMain.ResumeLayout(false);
            this.mnuDockOn.ResumeLayout(false);
            this.mnuDockOff.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.Panel panBottom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label btnColPanel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnSound;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnTask;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblPlaceholder;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnDock;
        private System.Windows.Forms.ContextMenuStrip mnuDockOn;
        private System.Windows.Forms.ToolStripMenuItem dockLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dockRightToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip mnuDockOff;
        private System.Windows.Forms.ToolStripMenuItem exitDockModeToolStripMenuItem;
        private System.Windows.Forms.Timer dockTimer;
        private System.Windows.Forms.Timer dockAnimTimer;
        private System.Windows.Forms.ToolStripMenuItem chkPin;
    }
}

