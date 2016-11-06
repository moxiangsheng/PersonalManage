namespace PersonnelManage
{
    partial class FrmAssessExample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAssessExample));
            this.btnNoPass = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPass = new System.Windows.Forms.Button();
            this.dgvAE = new System.Windows.Forms.DataGridView();
            this.AssExampleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalScores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTop = new System.Windows.Forms.Label();
            this.assesExampleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assesExampleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNoPass
            // 
            this.btnNoPass.Location = new System.Drawing.Point(290, 389);
            this.btnNoPass.Name = "btnNoPass";
            this.btnNoPass.Size = new System.Drawing.Size(75, 23);
            this.btnNoPass.TabIndex = 11;
            this.btnNoPass.Text = "审核不通过";
            this.btnNoPass.UseVisualStyleBackColor = true;
            this.btnNoPass.Click += new System.EventHandler(this.btnNoPass_Click);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(454, 389);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 12;
            this.btnSet.Text = "管理和设置";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(207, 389);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(126, 389);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(45, 389);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPass
            // 
            this.btnPass.Location = new System.Drawing.Point(372, 389);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(75, 23);
            this.btnPass.TabIndex = 15;
            this.btnPass.Text = "审核通过";
            this.btnPass.UseVisualStyleBackColor = true;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
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
            this.TotalScores,
            this.IsPass});
            this.dgvAE.Location = new System.Drawing.Point(20, 54);
            this.dgvAE.Name = "dgvAE";
            this.dgvAE.ReadOnly = true;
            this.dgvAE.RowTemplate.Height = 23;
            this.dgvAE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAE.Size = new System.Drawing.Size(534, 325);
            this.dgvAE.TabIndex = 9;
            // 
            // AssExampleId
            // 
            this.AssExampleId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AssExampleId.DataPropertyName = "AssesExampleId";
            this.AssExampleId.FillWeight = 75.12691F;
            this.AssExampleId.HeaderText = "编号";
            this.AssExampleId.Name = "AssExampleId";
            this.AssExampleId.ReadOnly = true;
            this.AssExampleId.Width = 80;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.DataPropertyName = "Title";
            this.Title.FillWeight = 304.5685F;
            this.Title.HeaderText = "标题";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // TotalScores
            // 
            this.TotalScores.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TotalScores.DataPropertyName = "TotalScore";
            this.TotalScores.FillWeight = 10.15228F;
            this.TotalScores.HeaderText = "满分";
            this.TotalScores.Name = "TotalScores";
            this.TotalScores.ReadOnly = true;
            // 
            // IsPass
            // 
            this.IsPass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IsPass.DataPropertyName = "IsPass";
            this.IsPass.FillWeight = 10.15228F;
            this.IsPass.HeaderText = "是否通过";
            this.IsPass.Name = "IsPass";
            this.IsPass.ReadOnly = true;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(379, 15);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 8;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(172, 16);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(187, 21);
            this.txtTitle.TabIndex = 7;
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTop.Location = new System.Drawing.Point(107, 16);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(51, 20);
            this.lblTop.TabIndex = 6;
            this.lblTop.Text = "标题：";
            // 
            // assesExampleBindingSource
            // 
            this.assesExampleBindingSource.DataMember = "AssesExample";
            // 
            // FrmAssessExample
            // 
            this.AcceptButton = this.btnQuery;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 423);
            this.Controls.Add(this.btnNoPass);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.dgvAE);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAssessExample";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "考核模板";
            this.Load += new System.EventHandler(this.FrmAssessExample_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assesExampleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNoPass;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.BindingSource assesExampleBindingSource;
        private System.Windows.Forms.DataGridView dgvAE;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssExampleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalScores;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsPass;
    }
}