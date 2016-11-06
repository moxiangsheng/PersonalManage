namespace PersonnelManage
{
    partial class FrmAssessDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAssessDetail));
            this.lblCurrentScore = new System.Windows.Forms.Label();
            this.lblTotalScore = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvAEDetail = new System.Windows.Forms.DataGridView();
            this.ASDetailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASDContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAEDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCurrentScore
            // 
            this.lblCurrentScore.AutoSize = true;
            this.lblCurrentScore.Location = new System.Drawing.Point(108, 52);
            this.lblCurrentScore.Name = "lblCurrentScore";
            this.lblCurrentScore.Size = new System.Drawing.Size(65, 12);
            this.lblCurrentScore.TabIndex = 17;
            this.lblCurrentScore.Text = "当前总分：";
            // 
            // lblTotalScore
            // 
            this.lblTotalScore.AutoSize = true;
            this.lblTotalScore.Location = new System.Drawing.Point(33, 52);
            this.lblTotalScore.Name = "lblTotalScore";
            this.lblTotalScore.Size = new System.Drawing.Size(41, 12);
            this.lblTotalScore.TabIndex = 16;
            this.lblTotalScore.Text = "总分：";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(354, 367);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(244, 367);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(134, 367);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvAEDetail
            // 
            this.dgvAEDetail.AllowUserToAddRows = false;
            this.dgvAEDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAEDetail.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAEDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAEDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ASDetailId,
            this.ASDContent,
            this.Score});
            this.dgvAEDetail.Location = new System.Drawing.Point(32, 105);
            this.dgvAEDetail.Name = "dgvAEDetail";
            this.dgvAEDetail.ReadOnly = true;
            this.dgvAEDetail.RowTemplate.Height = 23;
            this.dgvAEDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAEDetail.Size = new System.Drawing.Size(524, 255);
            this.dgvAEDetail.TabIndex = 12;
            // 
            // ASDetailId
            // 
            this.ASDetailId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ASDetailId.DataPropertyName = "ASDetailId";
            this.ASDetailId.HeaderText = "编号";
            this.ASDetailId.Name = "ASDetailId";
            this.ASDetailId.ReadOnly = true;
            this.ASDetailId.Width = 80;
            // 
            // ASDContent
            // 
            this.ASDContent.DataPropertyName = "ASDContent";
            this.ASDContent.HeaderText = "考核内容";
            this.ASDContent.Name = "ASDContent";
            this.ASDContent.ReadOnly = true;
            // 
            // Score
            // 
            this.Score.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Score.DataPropertyName = "Score";
            this.Score.HeaderText = "单项总分";
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            this.Score.Width = 120;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(271, 75);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(101, 78);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(150, 21);
            this.txtContent.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "考核内容：";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(198, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(88, 25);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "模板标题";
            // 
            // FrmAssessDetail
            // 
            this.AcceptButton = this.btnQuery;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 402);
            this.Controls.Add(this.lblCurrentScore);
            this.Controls.Add(this.lblTotalScore);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvAEDetail);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAssessDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑模板";
            this.Load += new System.EventHandler(this.FrmAssessDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAEDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentScore;
        private System.Windows.Forms.Label lblTotalScore;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvAEDetail;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASDetailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASDContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
    }
}