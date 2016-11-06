namespace PersonnelManage
{
    partial class FrmShowMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShowMessage));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.lblSendDept = new System.Windows.Forms.Label();
            this.lblSendPosition = new System.Windows.Forms.Label();
            this.lblSender = new System.Windows.Forms.Label();
            this.lblSendTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "发送者：";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(24, 19);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(77, 12);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "发送者部门：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "发送者职位：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "发送时间：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "短信内容：";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(12, 144);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.Size = new System.Drawing.Size(300, 138);
            this.txtContent.TabIndex = 5;
            // 
            // lblSendDept
            // 
            this.lblSendDept.AutoSize = true;
            this.lblSendDept.Location = new System.Drawing.Point(107, 19);
            this.lblSendDept.Name = "lblSendDept";
            this.lblSendDept.Size = new System.Drawing.Size(0, 12);
            this.lblSendDept.TabIndex = 6;
            // 
            // lblSendPosition
            // 
            this.lblSendPosition.AutoSize = true;
            this.lblSendPosition.Location = new System.Drawing.Point(107, 47);
            this.lblSendPosition.Name = "lblSendPosition";
            this.lblSendPosition.Size = new System.Drawing.Size(0, 12);
            this.lblSendPosition.TabIndex = 7;
            // 
            // lblSender
            // 
            this.lblSender.AutoSize = true;
            this.lblSender.Location = new System.Drawing.Point(107, 72);
            this.lblSender.Name = "lblSender";
            this.lblSender.Size = new System.Drawing.Size(0, 12);
            this.lblSender.TabIndex = 8;
            // 
            // lblSendTime
            // 
            this.lblSendTime.AutoSize = true;
            this.lblSendTime.Location = new System.Drawing.Point(107, 98);
            this.lblSendTime.Name = "lblSendTime";
            this.lblSendTime.Size = new System.Drawing.Size(0, 12);
            this.lblSendTime.TabIndex = 9;
            // 
            // FrmShowMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 294);
            this.Controls.Add(this.lblSendTime);
            this.Controls.Add(this.lblSender);
            this.Controls.Add(this.lblSendPosition);
            this.Controls.Add(this.lblSendDept);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmShowMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查看短消息";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmShowMessage_FormClosed);
            this.Load += new System.EventHandler(this.FrmShowMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label lblSendDept;
        private System.Windows.Forms.Label lblSendPosition;
        private System.Windows.Forms.Label lblSender;
        private System.Windows.Forms.Label lblSendTime;
    }
}