using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PersonnelManage
{
    public partial class FrmMessageBox : Form
    {
        Point po;
        int showHigh;
        public FrmAdmin frmadmin;
        public FrmReceiveMessage frmrm;
        public FrmMessageBox()
        {
            InitializeComponent();
        }

        #region 窗体加载事件：窗体初始化位置及标签文本
        private void FrmMessageBox_Load(object sender, EventArgs e)
        {
            int X = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            int Y = Screen.PrimaryScreen.WorkingArea.Height;
            showHigh = Y - this.Height;
            po = new Point(X, Y);
            this.Location = po;
            this.lblTitle.Text = "有"+Common.GetEmploryeeNameByEpId(Common.EpId) + "发来的消息，请注意查收!";
        } 
        #endregion

        #region 计时器事件：位置变化
        private void timeShow_Tick(object sender, EventArgs e)
        {
            if (po != null)
            {
                if (po.Y >= showHigh)
                {
                    po.Y -= 3;
                    this.Location = po;
                }
                else
                {
                    timeShow.Enabled = false;
                }
            }
        } 
        #endregion

        #region 方法一：判断窗体状态，置空。
        private void FrmMessageBox_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmadmin.frmmbox = null;
        }
        #endregion

        #region 事件：查看
        private void btnLook_Click(object sender, EventArgs e)
        {
            if (frmadmin.frm == null)
            {
                frmadmin.frm = new FrmReceiveMessage();
            }

            frmadmin.frm.MdiParent = frmadmin;
            frmadmin.frm.Show();
        } 
        #endregion


    }
}
