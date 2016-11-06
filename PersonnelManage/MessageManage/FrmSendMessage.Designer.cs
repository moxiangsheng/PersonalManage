namespace PersonnelManage
{
    partial class FrmSendMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSendMessage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dgvEmplory = new System.Windows.Forms.DataGridView();
            this.EpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PositionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsSend = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSend = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtEmploryName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmplory)).BeginInit();
            this.cmsSend.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "部门";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "职位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "员工姓名";
            // 
            // cmbDept
            // 
            this.cmbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Location = new System.Drawing.Point(57, 16);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(110, 20);
            this.cmbDept.TabIndex = 3;
            this.cmbDept.SelectedIndexChanged += new System.EventHandler(this.cmbDept_SelectedIndexChanged);
            // 
            // cmbPosition
            // 
            this.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(210, 16);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(121, 20);
            this.cmbPosition.TabIndex = 4;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(544, 15);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(70, 23);
            this.btnQuery.TabIndex = 6;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dgvEmplory
            // 
            this.dgvEmplory.AllowUserToAddRows = false;
            this.dgvEmplory.AllowUserToDeleteRows = false;
            this.dgvEmplory.AllowUserToResizeColumns = false;
            this.dgvEmplory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmplory.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvEmplory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmplory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EpId,
            this.EpName,
            this.Gender,
            this.DeptName,
            this.PositionName});
            this.dgvEmplory.ContextMenuStrip = this.cmsSend;
            this.dgvEmplory.Location = new System.Drawing.Point(24, 47);
            this.dgvEmplory.Name = "dgvEmplory";
            this.dgvEmplory.ReadOnly = true;
            this.dgvEmplory.RowTemplate.Height = 23;
            this.dgvEmplory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmplory.Size = new System.Drawing.Size(682, 317);
            this.dgvEmplory.TabIndex = 7;
            this.dgvEmplory.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEmplory_CellMouseDown);
            // 
            // EpId
            // 
            this.EpId.DataPropertyName = "EpId";
            this.EpId.HeaderText = "员工编号";
            this.EpId.Name = "EpId";
            this.EpId.ReadOnly = true;
            // 
            // EpName
            // 
            this.EpName.DataPropertyName = "EpName";
            this.EpName.HeaderText = "员工姓名";
            this.EpName.Name = "EpName";
            this.EpName.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "性别";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // DeptName
            // 
            this.DeptName.DataPropertyName = "DeptName";
            this.DeptName.HeaderText = "所属部门";
            this.DeptName.Name = "DeptName";
            this.DeptName.ReadOnly = true;
            // 
            // PositionName
            // 
            this.PositionName.DataPropertyName = "positionName";
            this.PositionName.HeaderText = "职位";
            this.PositionName.Name = "PositionName";
            this.PositionName.ReadOnly = true;
            // 
            // cmsSend
            // 
            this.cmsSend.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSend});
            this.cmsSend.Name = "cmsSend";
            this.cmsSend.Size = new System.Drawing.Size(125, 26);
            // 
            // tsmiSend
            // 
            this.tsmiSend.Name = "tsmiSend";
            this.tsmiSend.Size = new System.Drawing.Size(124, 22);
            this.tsmiSend.Text = "发送消息";
            this.tsmiSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(620, 15);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "发送消息";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtEmploryName
            // 
            this.txtEmploryName.Location = new System.Drawing.Point(410, 15);
            this.txtEmploryName.Name = "txtEmploryName";
            this.txtEmploryName.Size = new System.Drawing.Size(100, 21);
            this.txtEmploryName.TabIndex = 9;
            // 
            // FrmSendMessage
            // 
            this.AcceptButton = this.btnQuery;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 382);
            this.Controls.Add(this.txtEmploryName);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.dgvEmplory);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.cmbPosition);
            this.Controls.Add(this.cmbDept);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSendMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "发送短消息";
            this.Load += new System.EventHandler(this.FrmSendMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmplory)).EndInit();
            this.cmsSend.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DataGridView dgvEmplory;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtEmploryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeptName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionName;
        private System.Windows.Forms.ContextMenuStrip cmsSend;
        private System.Windows.Forms.ToolStripMenuItem tsmiSend;
    }
}