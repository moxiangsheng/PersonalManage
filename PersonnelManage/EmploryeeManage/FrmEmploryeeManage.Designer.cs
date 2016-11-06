namespace PersonnelManage
{
    partial class FrmEmploryeeManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmploryeeManage));
            this.label4 = new System.Windows.Forms.Label();
            this.rbtAllGender = new System.Windows.Forms.RadioButton();
            this.rbtGirl = new System.Windows.Forms.RadioButton();
            this.rbtBoy = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEmploryeeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEmploryeeInfo = new System.Windows.Forms.DataGridView();
            this.EpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobilePhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officePhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsEmploryeeInfo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEditEmploryee = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmploryeeDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteEmploryee = new System.Windows.Forms.ToolStripMenuItem();
            this.Lbtishi = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.cmbDepart = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmploryeeInfo)).BeginInit();
            this.cmsEmploryeeInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 37;
            this.label4.Text = "所在职位:";
            // 
            // rbtAllGender
            // 
            this.rbtAllGender.AutoSize = true;
            this.rbtAllGender.Checked = true;
            this.rbtAllGender.Location = new System.Drawing.Point(9, 7);
            this.rbtAllGender.Name = "rbtAllGender";
            this.rbtAllGender.Size = new System.Drawing.Size(47, 16);
            this.rbtAllGender.TabIndex = 9;
            this.rbtAllGender.TabStop = true;
            this.rbtAllGender.Text = "所有";
            this.rbtAllGender.UseVisualStyleBackColor = true;
            // 
            // rbtGirl
            // 
            this.rbtGirl.AutoSize = true;
            this.rbtGirl.Location = new System.Drawing.Point(112, 8);
            this.rbtGirl.Name = "rbtGirl";
            this.rbtGirl.Size = new System.Drawing.Size(35, 16);
            this.rbtGirl.TabIndex = 8;
            this.rbtGirl.Text = "女";
            this.rbtGirl.UseVisualStyleBackColor = true;
            // 
            // rbtBoy
            // 
            this.rbtBoy.AutoSize = true;
            this.rbtBoy.Location = new System.Drawing.Point(62, 8);
            this.rbtBoy.Name = "rbtBoy";
            this.rbtBoy.Size = new System.Drawing.Size(35, 16);
            this.rbtBoy.TabIndex = 7;
            this.rbtBoy.Text = "男";
            this.rbtBoy.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 33;
            this.label3.Text = "所在部门：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtAllGender);
            this.panel1.Controls.Add(this.rbtGirl);
            this.panel1.Controls.Add(this.rbtBoy);
            this.panel1.Location = new System.Drawing.Point(89, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 29);
            this.panel1.TabIndex = 2;
            // 
            // txtEmploryeeName
            // 
            this.txtEmploryeeName.Location = new System.Drawing.Point(89, 21);
            this.txtEmploryeeName.Name = "txtEmploryeeName";
            this.txtEmploryeeName.Size = new System.Drawing.Size(156, 21);
            this.txtEmploryeeName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 28;
            this.label2.Text = "性别：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 27;
            this.label1.Text = "姓名：";
            // 
            // dgvEmploryeeInfo
            // 
            this.dgvEmploryeeInfo.AllowUserToAddRows = false;
            this.dgvEmploryeeInfo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Cyan;
            this.dgvEmploryeeInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmploryeeInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmploryeeInfo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvEmploryeeInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmploryeeInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EpId,
            this.EpName,
            this.DeptName,
            this.positionName,
            this.gender,
            this.MobilePhone,
            this.officePhone});
            this.dgvEmploryeeInfo.ContextMenuStrip = this.cmsEmploryeeInfo;
            this.dgvEmploryeeInfo.Location = new System.Drawing.Point(30, 94);
            this.dgvEmploryeeInfo.Name = "dgvEmploryeeInfo";
            this.dgvEmploryeeInfo.ReadOnly = true;
            this.dgvEmploryeeInfo.RowTemplate.Height = 23;
            this.dgvEmploryeeInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmploryeeInfo.Size = new System.Drawing.Size(624, 283);
            this.dgvEmploryeeInfo.TabIndex = 26;
            this.dgvEmploryeeInfo.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEmploryeeInfo_CellMouseDown);
            // 
            // EpId
            // 
            this.EpId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EpId.DataPropertyName = "EpId";
            this.EpId.HeaderText = "工号";
            this.EpId.Name = "EpId";
            this.EpId.ReadOnly = true;
            this.EpId.Width = 55;
            // 
            // EpName
            // 
            this.EpName.DataPropertyName = "EpName";
            this.EpName.HeaderText = "姓名";
            this.EpName.Name = "EpName";
            this.EpName.ReadOnly = true;
            // 
            // DeptName
            // 
            this.DeptName.DataPropertyName = "DeptName";
            this.DeptName.HeaderText = "部门";
            this.DeptName.Name = "DeptName";
            this.DeptName.ReadOnly = true;
            // 
            // positionName
            // 
            this.positionName.DataPropertyName = "positionName";
            this.positionName.HeaderText = "职位";
            this.positionName.Name = "positionName";
            this.positionName.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "性别";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // MobilePhone
            // 
            this.MobilePhone.DataPropertyName = "MobilePhone";
            this.MobilePhone.HeaderText = "手机号";
            this.MobilePhone.Name = "MobilePhone";
            this.MobilePhone.ReadOnly = true;
            // 
            // officePhone
            // 
            this.officePhone.DataPropertyName = "officePhone";
            this.officePhone.HeaderText = "工作号";
            this.officePhone.Name = "officePhone";
            this.officePhone.ReadOnly = true;
            // 
            // cmsEmploryeeInfo
            // 
            this.cmsEmploryeeInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditEmploryee,
            this.tsmiEmploryeeDetail,
            this.tsmiDeleteEmploryee});
            this.cmsEmploryeeInfo.Name = "cmsEmploryeeInfo";
            this.cmsEmploryeeInfo.Size = new System.Drawing.Size(101, 70);
            // 
            // tsmiEditEmploryee
            // 
            this.tsmiEditEmploryee.Name = "tsmiEditEmploryee";
            this.tsmiEditEmploryee.Size = new System.Drawing.Size(100, 22);
            this.tsmiEditEmploryee.Text = "编辑";
            this.tsmiEditEmploryee.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // tsmiEmploryeeDetail
            // 
            this.tsmiEmploryeeDetail.Name = "tsmiEmploryeeDetail";
            this.tsmiEmploryeeDetail.Size = new System.Drawing.Size(100, 22);
            this.tsmiEmploryeeDetail.Text = "详情";
            this.tsmiEmploryeeDetail.Click += new System.EventHandler(this.tsmiEmploryeeDetail_Click);
            // 
            // tsmiDeleteEmploryee
            // 
            this.tsmiDeleteEmploryee.Name = "tsmiDeleteEmploryee";
            this.tsmiDeleteEmploryee.Size = new System.Drawing.Size(100, 22);
            this.tsmiDeleteEmploryee.Text = "删除";
            this.tsmiDeleteEmploryee.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Lbtishi
            // 
            this.Lbtishi.AutoSize = true;
            this.Lbtishi.Location = new System.Drawing.Point(524, 62);
            this.Lbtishi.Name = "Lbtishi";
            this.Lbtishi.Size = new System.Drawing.Size(0, 12);
            this.Lbtishi.TabIndex = 39;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(560, 21);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 5;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQurey_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(498, 383);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(579, 383);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(417, 383);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // cmbPosition
            // 
            this.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(371, 61);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(121, 20);
            this.cmbPosition.TabIndex = 4;
            // 
            // cmbDepart
            // 
            this.cmbDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepart.FormattingEnabled = true;
            this.cmbDepart.Location = new System.Drawing.Point(371, 23);
            this.cmbDepart.Name = "cmbDepart";
            this.cmbDepart.Size = new System.Drawing.Size(121, 20);
            this.cmbDepart.TabIndex = 3;
            this.cmbDepart.SelectedIndexChanged += new System.EventHandler(this.cmbDepart_SelectedIndexChanged_1);
            // 
            // FrmEmploryeeManage
            // 
            this.AcceptButton = this.btnQuery;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 424);
            this.Controls.Add(this.cmbDepart);
            this.Controls.Add(this.cmbPosition);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.Lbtishi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtEmploryeeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEmploryeeInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEmploryeeManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工管理";
            this.Load += new System.EventHandler(this.FrmEmploryeeManage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmploryeeInfo)).EndInit();
            this.cmsEmploryeeInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtAllGender;
        private System.Windows.Forms.RadioButton rbtGirl;
        private System.Windows.Forms.RadioButton rbtBoy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEmploryeeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEmploryeeInfo;
        private System.Windows.Forms.Label Lbtishi;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.ComboBox cmbDepart;
        private System.Windows.Forms.DataGridViewTextBoxColumn EpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeptName;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobilePhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn officePhone;
        private System.Windows.Forms.ContextMenuStrip cmsEmploryeeInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditEmploryee;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmploryeeDetail;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteEmploryee;
    }
}