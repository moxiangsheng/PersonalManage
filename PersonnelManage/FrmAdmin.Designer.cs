namespace PersonnelManage
{
    partial class FrmAdmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditPwd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.员工管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddEmploryee = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmploryeeManage = new System.Windows.Forms.ToolStripMenuItem();
            this.部门管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddDept = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeptManage = new System.Windows.Forms.ToolStripMenuItem();
            this.考核ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAccessExample = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAssessManage = new System.Windows.Forms.ToolStripMenuItem();
            this.短消息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSendMessage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReceiveMessage = new System.Windows.Forms.ToolStripMenuItem();
            this.视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStutasBar = new System.Windows.Forms.ToolStripMenuItem();
            this.窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGreenStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGrayRowStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBuleWaveStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUserManuals = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnEmployeeManage = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDepartmentManage = new System.Windows.Forms.ToolStripButton();
            this.tsbtnAssessManage = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSendMessage = new System.Windows.Forms.ToolStripButton();
            this.tsbtnReciveMessage = new System.Windows.Forms.ToolStripButton();
            this.tsbtnLock = new System.Windows.Forms.ToolStripButton();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.msMain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.BackColor = System.Drawing.SystemColors.Control;
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户管理ToolStripMenuItem,
            this.员工管理ToolStripMenuItem,
            this.部门管理ToolStripMenuItem,
            this.考核ToolStripMenuItem,
            this.短消息ToolStripMenuItem,
            this.视图ToolStripMenuItem,
            this.窗口ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(747, 25);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditPwd,
            this.tsmiExit});
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(85, 21);
            this.用户管理ToolStripMenuItem.Text = "用户管理(&U)";
            // 
            // tsmiEditPwd
            // 
            this.tsmiEditPwd.Name = "tsmiEditPwd";
            this.tsmiEditPwd.Size = new System.Drawing.Size(139, 22);
            this.tsmiEditPwd.Text = "修改密码(&P)";
            this.tsmiEditPwd.Click += new System.EventHandler(this.tsmiEditPwd_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(139, 22);
            this.tsmiExit.Text = "退出(&E)";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // 员工管理ToolStripMenuItem
            // 
            this.员工管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddEmploryee,
            this.tsmiEmploryeeManage});
            this.员工管理ToolStripMenuItem.Name = "员工管理ToolStripMenuItem";
            this.员工管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 21);
            this.员工管理ToolStripMenuItem.Text = "员工管理(&E)";
            // 
            // tsmiAddEmploryee
            // 
            this.tsmiAddEmploryee.Name = "tsmiAddEmploryee";
            this.tsmiAddEmploryee.Size = new System.Drawing.Size(168, 22);
            this.tsmiAddEmploryee.Text = "添加员工(&A)";
            this.tsmiAddEmploryee.Click += new System.EventHandler(this.tsmiAddEmploryee_Click);
            // 
            // tsmiEmploryeeManage
            // 
            this.tsmiEmploryeeManage.Name = "tsmiEmploryeeManage";
            this.tsmiEmploryeeManage.Size = new System.Drawing.Size(168, 22);
            this.tsmiEmploryeeManage.Text = "员工信息管理(&M)";
            this.tsmiEmploryeeManage.Click += new System.EventHandler(this.tsmiEmploryeeManage_Click);
            // 
            // 部门管理ToolStripMenuItem
            // 
            this.部门管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddDept,
            this.tsmiDeptManage});
            this.部门管理ToolStripMenuItem.Name = "部门管理ToolStripMenuItem";
            this.部门管理ToolStripMenuItem.Size = new System.Drawing.Size(85, 21);
            this.部门管理ToolStripMenuItem.Text = "部门管理(&D)";
            // 
            // tsmiAddDept
            // 
            this.tsmiAddDept.Name = "tsmiAddDept";
            this.tsmiAddDept.Size = new System.Drawing.Size(168, 22);
            this.tsmiAddDept.Text = "添加部门(&A)";
            this.tsmiAddDept.Click += new System.EventHandler(this.tsmiAddDept_Click);
            // 
            // tsmiDeptManage
            // 
            this.tsmiDeptManage.Name = "tsmiDeptManage";
            this.tsmiDeptManage.Size = new System.Drawing.Size(168, 22);
            this.tsmiDeptManage.Text = "部门信息管理(&M)";
            this.tsmiDeptManage.Click += new System.EventHandler(this.tsmiDeptManage_Click);
            // 
            // 考核ToolStripMenuItem
            // 
            this.考核ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAccessExample,
            this.tsmiAssessManage});
            this.考核ToolStripMenuItem.Name = "考核ToolStripMenuItem";
            this.考核ToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.考核ToolStripMenuItem.Text = "考核(&A)";
            // 
            // tsmiAccessExample
            // 
            this.tsmiAccessExample.Name = "tsmiAccessExample";
            this.tsmiAccessExample.Size = new System.Drawing.Size(152, 22);
            this.tsmiAccessExample.Text = "考核模板(&M)";
            this.tsmiAccessExample.Click += new System.EventHandler(this.tsmiAccessExample_Click);
            // 
            // tsmiAssessManage
            // 
            this.tsmiAssessManage.Name = "tsmiAssessManage";
            this.tsmiAssessManage.Size = new System.Drawing.Size(152, 22);
            this.tsmiAssessManage.Text = "考核管理(&M)";
            this.tsmiAssessManage.Click += new System.EventHandler(this.tsmiAssessManage_Click);
            // 
            // 短消息ToolStripMenuItem
            // 
            this.短消息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSendMessage,
            this.tsmiReceiveMessage});
            this.短消息ToolStripMenuItem.Name = "短消息ToolStripMenuItem";
            this.短消息ToolStripMenuItem.Size = new System.Drawing.Size(76, 21);
            this.短消息ToolStripMenuItem.Text = "短消息(&M)";
            // 
            // tsmiSendMessage
            // 
            this.tsmiSendMessage.Name = "tsmiSendMessage";
            this.tsmiSendMessage.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.tsmiSendMessage.Size = new System.Drawing.Size(201, 22);
            this.tsmiSendMessage.Text = "发送短消息(&S)";
            this.tsmiSendMessage.Click += new System.EventHandler(this.tsmiSendMessage_Click);
            // 
            // tsmiReceiveMessage
            // 
            this.tsmiReceiveMessage.Name = "tsmiReceiveMessage";
            this.tsmiReceiveMessage.Size = new System.Drawing.Size(201, 22);
            this.tsmiReceiveMessage.Text = "接收短消息(&R)";
            this.tsmiReceiveMessage.Click += new System.EventHandler(this.tsmiReceiveMessage_Click);
            // 
            // 视图ToolStripMenuItem
            // 
            this.视图ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiToolStripMenu,
            this.tsmiStutasBar});
            this.视图ToolStripMenuItem.Name = "视图ToolStripMenuItem";
            this.视图ToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.视图ToolStripMenuItem.Text = "视图(&V)";
            // 
            // tsmiToolStripMenu
            // 
            this.tsmiToolStripMenu.Checked = true;
            this.tsmiToolStripMenu.CheckOnClick = true;
            this.tsmiToolStripMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiToolStripMenu.Name = "tsmiToolStripMenu";
            this.tsmiToolStripMenu.Size = new System.Drawing.Size(127, 22);
            this.tsmiToolStripMenu.Text = "工具栏(&T)";
            this.tsmiToolStripMenu.Click += new System.EventHandler(this.tsmiToolStripMenu_Click);
            // 
            // tsmiStutasBar
            // 
            this.tsmiStutasBar.Checked = true;
            this.tsmiStutasBar.CheckOnClick = true;
            this.tsmiStutasBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiStutasBar.Name = "tsmiStutasBar";
            this.tsmiStutasBar.Size = new System.Drawing.Size(127, 22);
            this.tsmiStutasBar.Text = "状态栏(&S)";
            this.tsmiStutasBar.Click += new System.EventHandler(this.tsmiStutasBar_Click);
            // 
            // 窗口ToolStripMenuItem
            // 
            this.窗口ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStyle});
            this.窗口ToolStripMenuItem.Name = "窗口ToolStripMenuItem";
            this.窗口ToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.窗口ToolStripMenuItem.Text = "设置(&S)";
            // 
            // tsmiStyle
            // 
            this.tsmiStyle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDefault,
            this.tsmiGreenStyle,
            this.tsmiGrayRowStyle,
            this.tsmiBuleWaveStyle});
            this.tsmiStyle.Name = "tsmiStyle";
            this.tsmiStyle.Size = new System.Drawing.Size(139, 22);
            this.tsmiStyle.Text = "风格样式(&S)";
            // 
            // tsmiDefault
            // 
            this.tsmiDefault.Name = "tsmiDefault";
            this.tsmiDefault.Size = new System.Drawing.Size(124, 22);
            this.tsmiDefault.Text = "默认风格";
            this.tsmiDefault.Click += new System.EventHandler(this.tsmiDefault_Click);
            // 
            // tsmiGreenStyle
            // 
            this.tsmiGreenStyle.Name = "tsmiGreenStyle";
            this.tsmiGreenStyle.Size = new System.Drawing.Size(124, 22);
            this.tsmiGreenStyle.Text = "绿色家园";
            this.tsmiGreenStyle.Click += new System.EventHandler(this.tsmiBlueStyle_Click);
            // 
            // tsmiGrayRowStyle
            // 
            this.tsmiGrayRowStyle.Name = "tsmiGrayRowStyle";
            this.tsmiGrayRowStyle.Size = new System.Drawing.Size(124, 22);
            this.tsmiGrayRowStyle.Text = "灰色轨迹";
            this.tsmiGrayRowStyle.Click += new System.EventHandler(this.tsmiGrayRowStyle_Click);
            // 
            // tsmiBuleWaveStyle
            // 
            this.tsmiBuleWaveStyle.Name = "tsmiBuleWaveStyle";
            this.tsmiBuleWaveStyle.Size = new System.Drawing.Size(124, 22);
            this.tsmiBuleWaveStyle.Text = "蓝色波浪";
            this.tsmiBuleWaveStyle.Click += new System.EventHandler(this.tsmiBuleWaveStyle_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUserManuals,
            this.tsmiAbout});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助ToolStripMenuItem.Text = "帮助(&H)";
            // 
            // tsmiUserManuals
            // 
            this.tsmiUserManuals.Name = "tsmiUserManuals";
            this.tsmiUserManuals.Size = new System.Drawing.Size(141, 22);
            this.tsmiUserManuals.Text = "用户手册(&U)";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(141, 22);
            this.tsmiAbout.Text = "关于(&A)";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowMerge = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnEmployeeManage,
            this.tsbtnDepartmentManage,
            this.tsbtnAssessManage,
            this.tsbtnSendMessage,
            this.tsbtnReciveMessage,
            this.tsbtnLock});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(747, 40);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnEmployeeManage
            // 
            this.tsbtnEmployeeManage.ForeColor = System.Drawing.Color.Black;
            this.tsbtnEmployeeManage.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEmployeeManage.Image")));
            this.tsbtnEmployeeManage.Name = "tsbtnEmployeeManage";
            this.tsbtnEmployeeManage.Size = new System.Drawing.Size(60, 37);
            this.tsbtnEmployeeManage.Text = "员工管理";
            this.tsbtnEmployeeManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnEmployeeManage.Click += new System.EventHandler(this.tsmiEmploryeeManage_Click);
            // 
            // tsbtnDepartmentManage
            // 
            this.tsbtnDepartmentManage.ForeColor = System.Drawing.Color.Black;
            this.tsbtnDepartmentManage.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDepartmentManage.Image")));
            this.tsbtnDepartmentManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDepartmentManage.Name = "tsbtnDepartmentManage";
            this.tsbtnDepartmentManage.Size = new System.Drawing.Size(60, 37);
            this.tsbtnDepartmentManage.Text = "部门管理";
            this.tsbtnDepartmentManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnDepartmentManage.Click += new System.EventHandler(this.tsmiDeptManage_Click);
            // 
            // tsbtnAssessManage
            // 
            this.tsbtnAssessManage.ForeColor = System.Drawing.Color.Black;
            this.tsbtnAssessManage.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAssessManage.Image")));
            this.tsbtnAssessManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAssessManage.Name = "tsbtnAssessManage";
            this.tsbtnAssessManage.Size = new System.Drawing.Size(60, 37);
            this.tsbtnAssessManage.Text = "考核管理";
            this.tsbtnAssessManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnAssessManage.Click += new System.EventHandler(this.tsmiAssessManage_Click);
            // 
            // tsbtnSendMessage
            // 
            this.tsbtnSendMessage.ForeColor = System.Drawing.Color.Black;
            this.tsbtnSendMessage.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSendMessage.Image")));
            this.tsbtnSendMessage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSendMessage.Name = "tsbtnSendMessage";
            this.tsbtnSendMessage.Size = new System.Drawing.Size(36, 37);
            this.tsbtnSendMessage.Text = "写信";
            this.tsbtnSendMessage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnSendMessage.Click += new System.EventHandler(this.tsmiSendMessage_Click);
            // 
            // tsbtnReciveMessage
            // 
            this.tsbtnReciveMessage.ForeColor = System.Drawing.Color.Black;
            this.tsbtnReciveMessage.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnReciveMessage.Image")));
            this.tsbtnReciveMessage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnReciveMessage.Name = "tsbtnReciveMessage";
            this.tsbtnReciveMessage.Size = new System.Drawing.Size(36, 37);
            this.tsbtnReciveMessage.Text = "收信";
            this.tsbtnReciveMessage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnReciveMessage.Click += new System.EventHandler(this.tsmiReceiveMessage_Click);
            // 
            // tsbtnLock
            // 
            this.tsbtnLock.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnLock.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnLock.Image")));
            this.tsbtnLock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnLock.Name = "tsbtnLock";
            this.tsbtnLock.Size = new System.Drawing.Size(36, 21);
            this.tsbtnLock.Text = "锁定";
            this.tsbtnLock.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsbtnLock.Click += new System.EventHandler(this.tsbtnLock_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTime.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime.ForeColor = System.Drawing.Color.Red;
            this.lblTime.Location = new System.Drawing.Point(0, 382);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(80, 18);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "北京时间";
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(747, 400);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.msMain);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.msMain;
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "欢迎进入人事管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAdmin_FormClosed);
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAdmin_KeyDown);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditPwd;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem 员工管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 部门管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 考核ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 短消息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 窗口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserManuals;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddEmploryee;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmploryeeManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddDept;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeptManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiAccessExample;
        private System.Windows.Forms.ToolStripMenuItem tsmiAssessManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiSendMessage;
        private System.Windows.Forms.ToolStripMenuItem tsmiReceiveMessage;
        private System.Windows.Forms.ToolStripMenuItem tsmiStyle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem tsmiDefault;
        private System.Windows.Forms.ToolStripMenuItem tsmiGreenStyle;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnEmployeeManage;
        private System.Windows.Forms.ToolStripButton tsbtnDepartmentManage;
        private System.Windows.Forms.ToolStripButton tsbtnAssessManage;
        private System.Windows.Forms.ToolStripButton tsbtnSendMessage;
        private System.Windows.Forms.ToolStripButton tsbtnReciveMessage;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ToolStripButton tsbtnLock;
        private System.Windows.Forms.ToolStripMenuItem tsmiBuleWaveStyle;
        private System.Windows.Forms.ToolStripMenuItem tsmiGrayRowStyle;
        private System.Windows.Forms.ToolStripMenuItem 视图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiStutasBar;

    }
}