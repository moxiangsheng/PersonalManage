namespace PersonnelManage
{
    partial class FrmSendBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSendBox));
            this.lblAccepter = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.txtAccepter = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAccepter
            // 
            this.lblAccepter.AutoSize = true;
            this.lblAccepter.Location = new System.Drawing.Point(26, 15);
            this.lblAccepter.Name = "lblAccepter";
            this.lblAccepter.Size = new System.Drawing.Size(53, 12);
            this.lblAccepter.TabIndex = 0;
            this.lblAccepter.Text = "接收人：";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(14, 103);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(65, 12);
            this.lblContent.TabIndex = 1;
            this.lblContent.Text = "消息内容：";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(194, 211);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(61, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.Location = new System.Drawing.Point(262, 211);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(60, 23);
            this.btnCancle.TabIndex = 3;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // txtAccepter
            // 
            this.txtAccepter.Location = new System.Drawing.Point(78, 12);
            this.txtAccepter.Multiline = true;
            this.txtAccepter.Name = "txtAccepter";
            this.txtAccepter.ReadOnly = true;
            this.txtAccepter.Size = new System.Drawing.Size(242, 55);
            this.txtAccepter.TabIndex = 4;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(78, 91);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(244, 102);
            this.txtContent.TabIndex = 5;
            // 
            // FrmSendBox
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancle;
            this.ClientSize = new System.Drawing.Size(359, 247);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtAccepter);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.lblAccepter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmSendBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "发送";
            this.Load += new System.EventHandler(this.FrmSendBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccepter;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.TextBox txtAccepter;
        private System.Windows.Forms.TextBox txtContent;

    }
}