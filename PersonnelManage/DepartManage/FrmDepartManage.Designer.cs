namespace PersonnelManage
{
    partial class FrmDepartManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepartManage));
            this.lblDepartName = new System.Windows.Forms.Label();
            this.txtDepartName = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dgvDepart = new System.Windows.Forms.DataGridView();
            this.DeptId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsDepart = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAddDepart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditDepart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteDepart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeatilDepart = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddDepart = new System.Windows.Forms.Button();
            this.btnEditDepart = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepart)).BeginInit();
            this.cmsDepart.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDepartName
            // 
            this.lblDepartName.AutoSize = true;
            this.lblDepartName.Location = new System.Drawing.Point(29, 32);
            this.lblDepartName.Name = "lblDepartName";
            this.lblDepartName.Size = new System.Drawing.Size(41, 12);
            this.lblDepartName.TabIndex = 0;
            this.lblDepartName.Text = "部门：";
            // 
            // txtDepartName
            // 
            this.txtDepartName.Location = new System.Drawing.Point(64, 29);
            this.txtDepartName.Name = "txtDepartName";
            this.txtDepartName.Size = new System.Drawing.Size(162, 21);
            this.txtDepartName.TabIndex = 1;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(251, 27);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(63, 23);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dgvDepart
            // 
            this.dgvDepart.AllowUserToAddRows = false;
            this.dgvDepart.AllowUserToDeleteRows = false;
            this.dgvDepart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepart.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDepart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeptId,
            this.deptName});
            this.dgvDepart.ContextMenuStrip = this.cmsDepart;
            this.dgvDepart.Location = new System.Drawing.Point(22, 56);
            this.dgvDepart.Name = "dgvDepart";
            this.dgvDepart.ReadOnly = true;
            this.dgvDepart.RowTemplate.Height = 23;
            this.dgvDepart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepart.Size = new System.Drawing.Size(575, 312);
            this.dgvDepart.TabIndex = 3;
            // 
            // DeptId
            // 
            this.DeptId.DataPropertyName = "DeptId";
            this.DeptId.HeaderText = "部门编号";
            this.DeptId.Name = "DeptId";
            this.DeptId.ReadOnly = true;
            // 
            // deptName
            // 
            this.deptName.DataPropertyName = "DeptName";
            this.deptName.HeaderText = "部门名";
            this.deptName.Name = "deptName";
            this.deptName.ReadOnly = true;
            // 
            // cmsDepart
            // 
            this.cmsDepart.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddDepart,
            this.tsmiEditDepart,
            this.tsmiDeleteDepart,
            this.tsmiDeatilDepart});
            this.cmsDepart.Name = "cmsDepart";
            this.cmsDepart.Size = new System.Drawing.Size(125, 92);
            // 
            // tsmiAddDepart
            // 
            this.tsmiAddDepart.Name = "tsmiAddDepart";
            this.tsmiAddDepart.Size = new System.Drawing.Size(124, 22);
            this.tsmiAddDepart.Text = "添加";
            this.tsmiAddDepart.Click += new System.EventHandler(this.btnAddDepart_Click);
            // 
            // tsmiEditDepart
            // 
            this.tsmiEditDepart.Name = "tsmiEditDepart";
            this.tsmiEditDepart.Size = new System.Drawing.Size(124, 22);
            this.tsmiEditDepart.Text = "修改";
            this.tsmiEditDepart.Click += new System.EventHandler(this.btnEditDepart_Click);
            // 
            // tsmiDeleteDepart
            // 
            this.tsmiDeleteDepart.Name = "tsmiDeleteDepart";
            this.tsmiDeleteDepart.Size = new System.Drawing.Size(124, 22);
            this.tsmiDeleteDepart.Text = "删除";
            this.tsmiDeleteDepart.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tsmiDeatilDepart
            // 
            this.tsmiDeatilDepart.Name = "tsmiDeatilDepart";
            this.tsmiDeatilDepart.Size = new System.Drawing.Size(124, 22);
            this.tsmiDeatilDepart.Text = "查看详情";
            this.tsmiDeatilDepart.Click += new System.EventHandler(this.tsmiDeatilDepart_Click);
            // 
            // btnAddDepart
            // 
            this.btnAddDepart.Location = new System.Drawing.Point(186, 391);
            this.btnAddDepart.Name = "btnAddDepart";
            this.btnAddDepart.Size = new System.Drawing.Size(75, 23);
            this.btnAddDepart.TabIndex = 4;
            this.btnAddDepart.Text = "添加";
            this.btnAddDepart.UseVisualStyleBackColor = true;
            this.btnAddDepart.Click += new System.EventHandler(this.btnAddDepart_Click);
            // 
            // btnEditDepart
            // 
            this.btnEditDepart.Location = new System.Drawing.Point(280, 391);
            this.btnEditDepart.Name = "btnEditDepart";
            this.btnEditDepart.Size = new System.Drawing.Size(75, 23);
            this.btnEditDepart.TabIndex = 5;
            this.btnEditDepart.Text = "修改";
            this.btnEditDepart.UseVisualStyleBackColor = true;
            this.btnEditDepart.Click += new System.EventHandler(this.btnEditDepart_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(373, 391);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmDepartManage
            // 
            this.AcceptButton = this.btnQuery;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 426);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditDepart);
            this.Controls.Add(this.btnAddDepart);
            this.Controls.Add(this.dgvDepart);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.txtDepartName);
            this.Controls.Add(this.lblDepartName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDepartManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "部门管理";
            this.Load += new System.EventHandler(this.FrmDeptManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepart)).EndInit();
            this.cmsDepart.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDepartName;
        private System.Windows.Forms.TextBox txtDepartName;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DataGridView dgvDepart;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeptId;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptName;
        private System.Windows.Forms.Button btnAddDepart;
        private System.Windows.Forms.Button btnEditDepart;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddDepart;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditDepart;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteDepart;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeatilDepart;
        private System.Windows.Forms.ContextMenuStrip cmsDepart;
    }
}