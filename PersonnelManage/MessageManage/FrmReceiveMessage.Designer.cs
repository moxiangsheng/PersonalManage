namespace PersonnelManage
{
    partial class FrmReceiveMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReceiveMessage));
            this.dgvMessage = new System.Windows.Forms.DataGridView();
            this.MessageId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MessageContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isRead = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsMessage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteMessage = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSendDepart = new System.Windows.Forms.Label();
            this.lblSendPositon = new System.Windows.Forms.Label();
            this.lblSendName = new System.Windows.Forms.Label();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnLook = new System.Windows.Forms.Button();
            this.txtSendName = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNoRead = new System.Windows.Forms.Button();
            this.btnIsRead = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessage)).BeginInit();
            this.cmsMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMessage
            // 
            this.dgvMessage.AllowUserToAddRows = false;
            this.dgvMessage.AllowUserToDeleteRows = false;
            this.dgvMessage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMessage.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMessage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MessageId,
            this.DeptName,
            this.positionName,
            this.EpName,
            this.MessageContent,
            this.SendTime,
            this.isRead});
            this.dgvMessage.ContextMenuStrip = this.cmsMessage;
            this.dgvMessage.Location = new System.Drawing.Point(25, 78);
            this.dgvMessage.Name = "dgvMessage";
            this.dgvMessage.ReadOnly = true;
            this.dgvMessage.RowTemplate.Height = 23;
            this.dgvMessage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMessage.Size = new System.Drawing.Size(742, 368);
            this.dgvMessage.TabIndex = 14;
            this.dgvMessage.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMessage_CellMouseDoubleClick);
            this.dgvMessage.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMessage_CellMouseDown);
            // 
            // MessageId
            // 
            this.MessageId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MessageId.DataPropertyName = "MessageId";
            this.MessageId.FillWeight = 80F;
            this.MessageId.Frozen = true;
            this.MessageId.HeaderText = "短信编号";
            this.MessageId.Name = "MessageId";
            this.MessageId.ReadOnly = true;
            this.MessageId.Width = 80;
            // 
            // DeptName
            // 
            this.DeptName.DataPropertyName = "DeptName";
            this.DeptName.HeaderText = "所属部门";
            this.DeptName.Name = "DeptName";
            this.DeptName.ReadOnly = true;
            // 
            // positionName
            // 
            this.positionName.DataPropertyName = "positionName";
            this.positionName.HeaderText = "所属职位";
            this.positionName.Name = "positionName";
            this.positionName.ReadOnly = true;
            // 
            // EpName
            // 
            this.EpName.DataPropertyName = "EpName";
            this.EpName.HeaderText = "发送者";
            this.EpName.Name = "EpName";
            this.EpName.ReadOnly = true;
            // 
            // MessageContent
            // 
            this.MessageContent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MessageContent.DataPropertyName = "MessageContent";
            this.MessageContent.FillWeight = 140F;
            this.MessageContent.HeaderText = "短信内容";
            this.MessageContent.Name = "MessageContent";
            this.MessageContent.ReadOnly = true;
            this.MessageContent.Width = 140;
            // 
            // SendTime
            // 
            this.SendTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SendTime.DataPropertyName = "SendTime";
            this.SendTime.FillWeight = 120F;
            this.SendTime.HeaderText = "发送时间";
            this.SendTime.Name = "SendTime";
            this.SendTime.ReadOnly = true;
            this.SendTime.Width = 120;
            // 
            // isRead
            // 
            this.isRead.DataPropertyName = "IsRead";
            this.isRead.HeaderText = "查看状态";
            this.isRead.Name = "isRead";
            this.isRead.ReadOnly = true;
            // 
            // cmsMessage
            // 
            this.cmsMessage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看ToolStripMenuItem,
            this.tsmiDeleteMessage});
            this.cmsMessage.Name = "cmsMessage";
            this.cmsMessage.Size = new System.Drawing.Size(149, 48);
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.查看ToolStripMenuItem.Text = "查看消息详情";
            this.查看ToolStripMenuItem.Click += new System.EventHandler(this.btnLook_Click);
            // 
            // tsmiDeleteMessage
            // 
            this.tsmiDeleteMessage.Name = "tsmiDeleteMessage";
            this.tsmiDeleteMessage.Size = new System.Drawing.Size(148, 22);
            this.tsmiDeleteMessage.Text = "删除消息";
            this.tsmiDeleteMessage.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblSendDepart
            // 
            this.lblSendDepart.AutoSize = true;
            this.lblSendDepart.Location = new System.Drawing.Point(23, 22);
            this.lblSendDepart.Name = "lblSendDepart";
            this.lblSendDepart.Size = new System.Drawing.Size(65, 12);
            this.lblSendDepart.TabIndex = 7;
            this.lblSendDepart.Text = "发送者部门";
            // 
            // lblSendPositon
            // 
            this.lblSendPositon.AutoSize = true;
            this.lblSendPositon.Location = new System.Drawing.Point(212, 22);
            this.lblSendPositon.Name = "lblSendPositon";
            this.lblSendPositon.Size = new System.Drawing.Size(65, 12);
            this.lblSendPositon.TabIndex = 8;
            this.lblSendPositon.Text = "发送者职位";
            // 
            // lblSendName
            // 
            this.lblSendName.AutoSize = true;
            this.lblSendName.Location = new System.Drawing.Point(410, 22);
            this.lblSendName.Name = "lblSendName";
            this.lblSendName.Size = new System.Drawing.Size(65, 12);
            this.lblSendName.TabIndex = 9;
            this.lblSendName.Text = "发送者姓名";
            // 
            // cmbDept
            // 
            this.cmbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Location = new System.Drawing.Point(96, 18);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(103, 20);
            this.cmbDept.TabIndex = 10;
            this.cmbDept.SelectedIndexChanged += new System.EventHandler(this.cmbDept_SelectedIndexChanged);
            // 
            // cmbPosition
            // 
            this.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(292, 18);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(105, 20);
            this.cmbPosition.TabIndex = 11;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(608, 17);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(49, 23);
            this.btnQuery.TabIndex = 13;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnLook
            // 
            this.btnLook.Location = new System.Drawing.Point(663, 17);
            this.btnLook.Name = "btnLook";
            this.btnLook.Size = new System.Drawing.Size(49, 23);
            this.btnLook.TabIndex = 15;
            this.btnLook.Text = "查看";
            this.btnLook.UseVisualStyleBackColor = true;
            this.btnLook.Click += new System.EventHandler(this.btnLook_Click);
            // 
            // txtSendName
            // 
            this.txtSendName.Location = new System.Drawing.Point(479, 18);
            this.txtSendName.Name = "txtSendName";
            this.txtSendName.Size = new System.Drawing.Size(113, 21);
            this.txtSendName.TabIndex = 16;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(718, 17);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(49, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNoRead
            // 
            this.btnNoRead.Location = new System.Drawing.Point(663, 45);
            this.btnNoRead.Name = "btnNoRead";
            this.btnNoRead.Size = new System.Drawing.Size(49, 23);
            this.btnNoRead.TabIndex = 18;
            this.btnNoRead.Text = "未读";
            this.btnNoRead.UseVisualStyleBackColor = true;
            this.btnNoRead.Click += new System.EventHandler(this.btnNoRead_Click);
            // 
            // btnIsRead
            // 
            this.btnIsRead.Location = new System.Drawing.Point(718, 45);
            this.btnIsRead.Name = "btnIsRead";
            this.btnIsRead.Size = new System.Drawing.Size(49, 23);
            this.btnIsRead.TabIndex = 19;
            this.btnIsRead.Text = "已读";
            this.btnIsRead.UseVisualStyleBackColor = true;
            this.btnIsRead.Click += new System.EventHandler(this.btnIsRead_Click);
            // 
            // FrmReceiveMessage
            // 
            this.AcceptButton = this.btnQuery;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(787, 464);
            this.Controls.Add(this.btnIsRead);
            this.Controls.Add(this.btnNoRead);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtSendName);
            this.Controls.Add(this.btnLook);
            this.Controls.Add(this.dgvMessage);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.cmbPosition);
            this.Controls.Add(this.cmbDept);
            this.Controls.Add(this.lblSendName);
            this.Controls.Add(this.lblSendPositon);
            this.Controls.Add(this.lblSendDepart);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReceiveMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "收件箱";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmReceiveMessage_FormClosed);
            this.Load += new System.EventHandler(this.FrmReceiveMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessage)).EndInit();
            this.cmsMessage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMessage;
        private System.Windows.Forms.ContextMenuStrip cmsMessage;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MessageId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeptName;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MessageContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn SendTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn isRead;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteMessage;
        private System.Windows.Forms.Label lblSendDepart;
        private System.Windows.Forms.Label lblSendPositon;
        private System.Windows.Forms.Label lblSendName;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnLook;
        private System.Windows.Forms.TextBox txtSendName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNoRead;
        private System.Windows.Forms.Button btnIsRead;
    }
}