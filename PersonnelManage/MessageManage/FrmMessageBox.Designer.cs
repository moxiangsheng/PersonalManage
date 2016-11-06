namespace PersonnelManage
{
    partial class FrmMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMessageBox));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLook = new System.Windows.Forms.Button();
            this.timeShow = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(161, 12);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "您有新的消息，请注意查收！";
            // 
            // btnLook
            // 
            this.btnLook.BackColor = System.Drawing.Color.Transparent;
            this.btnLook.Location = new System.Drawing.Point(70, 45);
            this.btnLook.Name = "btnLook";
            this.btnLook.Size = new System.Drawing.Size(62, 23);
            this.btnLook.TabIndex = 1;
            this.btnLook.Text = "查看消息";
            this.btnLook.UseVisualStyleBackColor = false;
            this.btnLook.Click += new System.EventHandler(this.btnLook_Click);
            // 
            // timeShow
            // 
            this.timeShow.Enabled = true;
            this.timeShow.Interval = 30;
            this.timeShow.Tick += new System.EventHandler(this.timeShow_Tick);
            // 
            // FrmMessageBox
            // 
            this.AcceptButton = this.btnLook;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 85);
            this.Controls.Add(this.btnLook);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMessageBox";
            this.Text = "消息提示";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMessageBox_FormClosed);
            this.Load += new System.EventHandler(this.FrmMessageBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLook;
        private System.Windows.Forms.Timer timeShow;
    }
}