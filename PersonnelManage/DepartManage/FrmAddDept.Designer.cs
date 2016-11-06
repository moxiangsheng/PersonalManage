namespace PersonnelManage
{
    partial class FrmAddDept
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddDept));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDepartFather = new System.Windows.Forms.ComboBox();
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.btnAddDept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblDepartId = new System.Windows.Forms.Label();
            this.txtDepartId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "上级部门：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "部门名：";
            // 
            // cmbDepartFather
            // 
            this.cmbDepartFather.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartFather.FormattingEnabled = true;
            this.cmbDepartFather.Location = new System.Drawing.Point(92, 40);
            this.cmbDepartFather.Name = "cmbDepartFather";
            this.cmbDepartFather.Size = new System.Drawing.Size(144, 20);
            this.cmbDepartFather.TabIndex = 1;
            // 
            // txtDeptName
            // 
            this.txtDeptName.Location = new System.Drawing.Point(92, 73);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(144, 21);
            this.txtDeptName.TabIndex = 2;
            // 
            // btnAddDept
            // 
            this.btnAddDept.Location = new System.Drawing.Point(89, 102);
            this.btnAddDept.Name = "btnAddDept";
            this.btnAddDept.Size = new System.Drawing.Size(62, 23);
            this.btnAddDept.TabIndex = 3;
            this.btnAddDept.Text = "添加";
            this.btnAddDept.UseVisualStyleBackColor = true;
            this.btnAddDept.Click += new System.EventHandler(this.btnAddDept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(175, 102);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(63, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblDepartId
            // 
            this.lblDepartId.AutoSize = true;
            this.lblDepartId.Location = new System.Drawing.Point(22, 14);
            this.lblDepartId.Name = "lblDepartId";
            this.lblDepartId.Size = new System.Drawing.Size(65, 12);
            this.lblDepartId.TabIndex = 5;
            this.lblDepartId.Text = "部门编号：";
            // 
            // txtDepartId
            // 
            this.txtDepartId.Location = new System.Drawing.Point(92, 9);
            this.txtDepartId.Name = "txtDepartId";
            this.txtDepartId.ReadOnly = true;
            this.txtDepartId.Size = new System.Drawing.Size(144, 21);
            this.txtDepartId.TabIndex = 6;
            // 
            // FrmAddDept
            // 
            this.AcceptButton = this.btnAddDept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(275, 141);
            this.Controls.Add(this.txtDepartId);
            this.Controls.Add(this.lblDepartId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddDept);
            this.Controls.Add(this.txtDeptName);
            this.Controls.Add(this.cmbDepartFather);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAddDept";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加部门";
            this.Load += new System.EventHandler(this.FrmAddDept_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDepartFather;
        private System.Windows.Forms.TextBox txtDeptName;
        private System.Windows.Forms.Button btnAddDept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblDepartId;
        private System.Windows.Forms.TextBox txtDepartId;
    }
}