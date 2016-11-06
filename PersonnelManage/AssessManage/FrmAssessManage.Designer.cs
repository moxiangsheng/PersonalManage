namespace PersonnelManage
{
    partial class FrmAssessManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAssessManage));
            this.btnInput = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvAssess = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dptAssessMonth = new System.Windows.Forms.DateTimePicker();
            this.btnShow = new System.Windows.Forms.Button();
            this.cmbPos = new System.Windows.Forms.ComboBox();
            this.cmbEpName = new System.Windows.Forms.ComboBox();
            this.lblTotalScore = new System.Windows.Forms.Label();
            this.lblSelfScore = new System.Windows.Forms.Label();
            this.lblFinalScore = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmsAssess = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AssessId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssesContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelfScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaderScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssess)).BeginInit();
            this.cmsAssess.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(435, 386);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(67, 23);
            this.btnInput.TabIndex = 17;
            this.btnInput.Text = "导入模板";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(616, 386);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(715, 386);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvAssess
            // 
            this.dgvAssess.AllowUserToAddRows = false;
            this.dgvAssess.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAssess.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAssess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssessId,
            this.Column7,
            this.AssesContent,
            this.Score,
            this.SelfScore,
            this.LeaderScore,
            this.Remark});
            this.dgvAssess.ContextMenuStrip = this.cmsAssess;
            this.dgvAssess.Location = new System.Drawing.Point(20, 71);
            this.dgvAssess.Name = "dgvAssess";
            this.dgvAssess.RowTemplate.Height = 23;
            this.dgvAssess.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssess.Size = new System.Drawing.Size(770, 304);
            this.dgvAssess.TabIndex = 23;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(521, 386);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dptAssessMonth
            // 
            this.dptAssessMonth.Location = new System.Drawing.Point(628, 18);
            this.dptAssessMonth.Name = "dptAssessMonth";
            this.dptAssessMonth.ShowUpDown = true;
            this.dptAssessMonth.Size = new System.Drawing.Size(81, 21);
            this.dptAssessMonth.TabIndex = 35;
            this.dptAssessMonth.ValueChanged += new System.EventHandler(this.dptAssessMonth_ValueChanged);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(715, 17);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 34;
            this.btnShow.Text = "查询";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click_1);
            // 
            // cmbPos
            // 
            this.cmbPos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPos.FormattingEnabled = true;
            this.cmbPos.Location = new System.Drawing.Point(232, 18);
            this.cmbPos.Name = "cmbPos";
            this.cmbPos.Size = new System.Drawing.Size(125, 20);
            this.cmbPos.TabIndex = 31;
            this.cmbPos.SelectedIndexChanged += new System.EventHandler(this.cmbPos_SelectedIndexChanged);
            // 
            // cmbEpName
            // 
            this.cmbEpName.FormattingEnabled = true;
            this.cmbEpName.Location = new System.Drawing.Point(402, 18);
            this.cmbEpName.Name = "cmbEpName";
            this.cmbEpName.Size = new System.Drawing.Size(158, 20);
            this.cmbEpName.TabIndex = 32;
            this.cmbEpName.SelectedIndexChanged += new System.EventHandler(this.cmbEpName_SelectedIndexChanged);
            // 
            // lblTotalScore
            // 
            this.lblTotalScore.AutoSize = true;
            this.lblTotalScore.Location = new System.Drawing.Point(24, 58);
            this.lblTotalScore.Name = "lblTotalScore";
            this.lblTotalScore.Size = new System.Drawing.Size(65, 12);
            this.lblTotalScore.TabIndex = 24;
            this.lblTotalScore.Text = "考核总分：";
            // 
            // lblSelfScore
            // 
            this.lblSelfScore.AutoSize = true;
            this.lblSelfScore.Location = new System.Drawing.Point(156, 58);
            this.lblSelfScore.Name = "lblSelfScore";
            this.lblSelfScore.Size = new System.Drawing.Size(65, 12);
            this.lblSelfScore.TabIndex = 25;
            this.lblSelfScore.Text = "自评得分：";
            // 
            // lblFinalScore
            // 
            this.lblFinalScore.AutoSize = true;
            this.lblFinalScore.Location = new System.Drawing.Point(275, 58);
            this.lblFinalScore.Name = "lblFinalScore";
            this.lblFinalScore.Size = new System.Drawing.Size(65, 12);
            this.lblFinalScore.TabIndex = 26;
            this.lblFinalScore.Text = "最终得分：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(566, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 27;
            this.label7.Text = "考核月份：";
            // 
            // cmbDept
            // 
            this.cmbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Location = new System.Drawing.Point(60, 18);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(121, 20);
            this.cmbDept.TabIndex = 33;
            this.cmbDept.SelectedIndexChanged += new System.EventHandler(this.cmbDept_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 28;
            this.label3.Text = "员工：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 29;
            this.label2.Text = "职位：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 30;
            this.label1.Text = "部门：";
            // 
            // cmsAssess
            // 
            this.cmsAssess.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDelete,
            this.删除ToolStripMenuItem});
            this.cmsAssess.Name = "cmsAssess";
            this.cmsAssess.Size = new System.Drawing.Size(101, 48);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(100, 22);
            this.tsmiDelete.Text = "导入";
            this.tsmiDelete.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // AssessId
            // 
            this.AssessId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AssessId.DataPropertyName = "AssessId";
            this.AssessId.HeaderText = "考核编号";
            this.AssessId.Name = "AssessId";
            this.AssessId.Width = 80;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column7.DataPropertyName = "EpName";
            this.Column7.FillWeight = 410.2564F;
            this.Column7.HeaderText = "考核员工";
            this.Column7.Name = "Column7";
            this.Column7.Width = 80;
            // 
            // AssesContent
            // 
            this.AssesContent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AssesContent.DataPropertyName = "AssesContent";
            this.AssesContent.FillWeight = 37.94872F;
            this.AssesContent.HeaderText = "考核内容";
            this.AssesContent.Name = "AssesContent";
            this.AssesContent.Width = 200;
            // 
            // Score
            // 
            this.Score.DataPropertyName = "Score";
            this.Score.FillWeight = 37.94872F;
            this.Score.HeaderText = "该项总分";
            this.Score.Name = "Score";
            // 
            // SelfScore
            // 
            this.SelfScore.DataPropertyName = "SelfScore";
            this.SelfScore.FillWeight = 37.94872F;
            this.SelfScore.HeaderText = "自评分";
            this.SelfScore.Name = "SelfScore";
            // 
            // LeaderScore
            // 
            this.LeaderScore.DataPropertyName = "LeaderScore";
            this.LeaderScore.FillWeight = 37.94872F;
            this.LeaderScore.HeaderText = "最后得分";
            this.LeaderScore.Name = "LeaderScore";
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.FillWeight = 37.94872F;
            this.Remark.HeaderText = "备注";
            this.Remark.Name = "Remark";
            // 
            // FrmAssessManage
            // 
            this.AcceptButton = this.btnShow;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 421);
            this.Controls.Add(this.dptAssessMonth);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.cmbPos);
            this.Controls.Add(this.cmbEpName);
            this.Controls.Add(this.lblTotalScore);
            this.Controls.Add(this.lblSelfScore);
            this.Controls.Add(this.lblFinalScore);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbDept);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvAssess);
            this.Controls.Add(this.btnAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAssessManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "考核管理";
            this.Load += new System.EventHandler(this.FrmAssessManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssess)).EndInit();
            this.cmsAssess.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvAssess;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dptAssessMonth;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ComboBox cmbPos;
        private System.Windows.Forms.ComboBox cmbEpName;
        private System.Windows.Forms.Label lblTotalScore;
        private System.Windows.Forms.Label lblSelfScore;
        private System.Windows.Forms.Label lblFinalScore;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cmsAssess;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssessId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssesContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelfScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaderScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;

    }
}