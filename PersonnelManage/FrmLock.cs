using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PersonnelManage
{
    public partial class FrmLock : Form
    {
        public FrmLock frmLock;
        int PwdErrorCount = 0;
        public FrmLock()
        {
            InitializeComponent();
        }

        #region 窗体加载事件：加载用户名
        private void FrmLock_Load(object sender, EventArgs e)
        {
            txtUserName.Text = Common.UserName;
        }
        #endregion

        #region 事件：关闭窗体时窗体不可关闭
        private void FrmLock_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        } 
        #endregion

        #region 事件：退出系统
        private void btnCancle_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("您的工作是否已经及时保存?\r\n您确定要退出系统吗?\r\n[点击确定退出]", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                Application.ExitThread();
            }
        } 
        #endregion

        #region 事件：解锁
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckInput())
           {
               StringBuilder sSql = new StringBuilder();
               sSql.AppendFormat("select LoginPwd from Users where LoginPwd='{0}'", txtUserPwd.Text.ToString().Trim());
               sSql.AppendFormat(" and LoginId='{0}'",Common.UserName);
               sqlHelper helper = new sqlHelper();
               SqlDataReader dr = helper.ExecuteRead(helper.connectionStr, sSql.ToString());
               if (dr.Read())
               {
                   if (dr["LoginPwd"].ToString().Trim() == txtUserPwd.Text.ToString().Trim())
                   {
                       this.Dispose();
                   } 
               }
               else
               {
                   MessageBox.Show("密码不正确！请重新输入！", Common.APTION, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   PwdErrorCount++;
               }

               if (PwdErrorCount >= 3)
               {
                  MessageBox.Show("您已连续3次输入密码错误，系统已被完全锁定，请两分钟之后再次重试！");
                  linkLabel2.Text = "密码输入3次错误，请两分钟之后重试！";
                  timer1.Enabled = true;//开启计时器
                  btnLogin.Enabled = false;//禁用解锁按钮
                }
           }      
        }  
        #endregion

        #region 方法：用户输入验证
        private bool CheckInput()
        {
            if (txtUserPwd.Text.Equals(string.Empty))
            {
                MessageBox.Show("您没有输入密码！", Common.APTION);
                return false;
            }
            else
            {
                return true;
            }
        } 
        #endregion

        #region 计时器事件：完全锁定系统，限制时间两分钟
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            btnLogin.Enabled = true;
            PwdErrorCount = 0;
            linkLabel2.Text = "系统已锁定,离开前建议您保存当前的工作！";
        } 
        #endregion
       

    }
}
