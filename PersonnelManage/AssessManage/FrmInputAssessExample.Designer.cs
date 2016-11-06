namespace PersonnelManage
{
    partial class FrmInputAssessExample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInputAssessExample));
            this.dgvAE = new System.Windows.Forms.DataGridView();
            this.AssExampleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalScores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTop = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAE)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAE
            // 
            this.dgvAE.AllowUserToAddRows = false;
            this.dgvAE.AllowUserToDeleteRows = false;
            this.dgvAE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAE.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssExampleId,
            this.Title,
            this.TotalScores});
            this.dgvAE.Location = new System.Drawing.Point(34, 76);
            this.dgvAE.Name = "dgvAE";
            this.dgvAE.ReadOnly = true;
            this.dgvAE.RowTemplate.Height = 23;
            this.dgvAE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAE.Size = new System.Drawing.Size(543, 315);
            this.dgvAE.TabIndex = 9;
            // 
            // AssExampleId
            // 
            this.AssExampleId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AssExampleId.DataPropertyName = "AssesExampleId";
            this.AssExampleId.HeaderText = "编号";
            this.AssExampleId.Name = "AssExampleId";
            this.AssExampleId.ReadOnly = true;
            this.AssExampleId.Width = 80;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "标题";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // TotalScores
            // 
            this.TotalScores.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TotalScores.DataPropertyName = "TotalScore";
            this.TotalScores.HeaderText = "满分";
            this.TotalScores.Name = "TotalScores";
            this.TotalScores.ReadOnly = true;
            // 
            // btnconfirm
            // 
            this.btnconfirm.Location = new System.Drawing.Point(395, 27);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(75, 23);
            this.btnconfirm.TabIndex = 13;
            this.btnconfirm.Text = "导入";
            this.btnconfirm.UseVisualStyleBackColor = true;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(302, 26);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 12;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(99, 28);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(187, 21);
            this.txtTitle.TabIndex = 1;
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTop.Location = new System.Drawing.Point(30, 27);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(40, 20);
            this.lblTop.TabIndex = 10;
            this.lblTop.Text = "标题:";
            // 
            // FrmInputAssessExample
            // 
            this.AcceptButton = this.btnQuery;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 414);
            this.Controls.Add(this.dgvAE);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmInputAssessExample";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "导入模板";
            this.Load += new System.EventHandler(this.FrmInputAssessExample_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAE;
        private System.Windows.Forms.Button btnconfirm;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssExampleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalScores;
    }
}