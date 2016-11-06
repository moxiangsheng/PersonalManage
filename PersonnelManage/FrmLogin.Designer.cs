namespace PersonnelManage
{
    partial class FrmLogin
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.bRegister = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.cmbLoginType = new System.Windows.Forms.ComboBox();
            this.lblLoginType = new System.Windows.Forms.Label();
            this.txtUserPwd = new System.Windows.Forms.TextBox();
            this.lblUserPwd = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(135, 170);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(60, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.Location = new System.Drawing.Point(210, 170);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(60, 23);
            this.btnCancle.TabIndex = 6;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // bRegister
            // 
            this.bRegister.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.bRegister.Location = new System.Drawing.Point(60, 170);
            this.bRegister.Name = "bRegister";
            this.bRegister.Size = new System.Drawing.Size(60, 23);
            this.bRegister.TabIndex = 4;
            this.bRegister.Text = "注册";
            this.bRegister.UseVisualStyleBackColor = true;
            this.bRegister.Click += new System.EventHandler(this.bRegister_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbUserName);
            this.groupBox1.Controls.Add(this.cmbLoginType);
            this.groupBox1.Controls.Add(this.lblLoginType);
            this.groupBox1.Controls.Add(this.txtUserPwd);
            this.groupBox1.Controls.Add(this.lblUserPwd);
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Location = new System.Drawing.Point(14, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 111);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // cmbUserName
            // 
            this.cmbUserName.ForeColor = System.Drawing.Color.Silver;
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.Location = new System.Drawing.Point(99, 17);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(155, 20);
            this.cmbUserName.TabIndex = 1;
            this.cmbUserName.Text = "请输入用户名";
            this.cmbUserName.DropDown += new System.EventHandler(this.cmbUserName_DropDown);
            this.cmbUserName.Enter += new System.EventHandler(this.cmbUserName_Enter);
            this.cmbUserName.Leave += new System.EventHandler(this.cmbUserName_Leave);
            // 
            // cmbLoginType
            // 
            this.cmbLoginType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoginType.FormattingEnabled = true;
            this.cmbLoginType.Items.AddRange(new object[] {
            "请选择",
            "管理员",
            "学员",
            "游客"});
            this.cmbLoginType.Location = new System.Drawing.Point(99, 80);
            this.cmbLoginType.Name = "cmbLoginType";
            this.cmbLoginType.Size = new System.Drawing.Size(155, 20);
            this.cmbLoginType.TabIndex = 12;
            // 
            // lblLoginType
            // 
            this.lblLoginType.AutoSize = true;
            this.lblLoginType.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginType.Location = new System.Drawing.Point(29, 83);
            this.lblLoginType.Name = "lblLoginType";
            this.lblLoginType.Size = new System.Drawing.Size(65, 12);
            this.lblLoginType.TabIndex = 13;
            this.lblLoginType.Text = "登录选项：";
            // 
            // txtUserPwd
            // 
            this.txtUserPwd.ForeColor = System.Drawing.Color.Silver;
            this.txtUserPwd.Location = new System.Drawing.Point(99, 48);
            this.txtUserPwd.Name = "txtUserPwd";
            this.txtUserPwd.Size = new System.Drawing.Size(155, 21);
            this.txtUserPwd.TabIndex = 10;
            this.txtUserPwd.Text = "密码";
            this.txtUserPwd.Enter += new System.EventHandler(this.txtUserPwd_Enter);
            this.txtUserPwd.Leave += new System.EventHandler(this.txtUserPwd_Leave);
            // 
            // lblUserPwd
            // 
            this.lblUserPwd.AutoSize = true;
            this.lblUserPwd.BackColor = System.Drawing.Color.Transparent;
            this.lblUserPwd.Location = new System.Drawing.Point(41, 51);
            this.lblUserPwd.Name = "lblUserPwd";
            this.lblUserPwd.Size = new System.Drawing.Size(53, 12);
            this.lblUserPwd.TabIndex = 11;
            this.lblUserPwd.Text = "密  码：";
            this.lblUserPwd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Location = new System.Drawing.Point(41, 20);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(53, 12);
            this.lblUserName.TabIndex = 9;
            this.lblUserName.Text = "用户名：";
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = global::PersonnelManage.Properties.Resources.LOGO;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Location = new System.Drawing.Point(-3, -5);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(324, 49);
            this.pbLogo.TabIndex = 8;
            this.pbLogo.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnCancle;
            this.ClientSize = new System.Drawing.Size(321, 202);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bRegister);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统登录";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button bRegister;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbLoginType;
        private System.Windows.Forms.Label lblLoginType;
        private System.Windows.Forms.TextBox txtUserPwd;
        private System.Windows.Forms.Label lblUserPwd;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.ComboBox cmbUserName;
    }
}

