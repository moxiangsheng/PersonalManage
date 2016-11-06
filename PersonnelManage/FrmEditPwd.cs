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
    public partial class FrmEditPwd : Form
    {
        public FrmEditPwd()
        {
            InitializeComponent();
        }

        #region 取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
        #endregion

        #region 保存,修改密码
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(CheckInput_EditPwd()){
                StringBuilder sSql = new StringBuilder();
                sSql.Append("update Users set ");
                sSql.AppendFormat("LoginPwd='{0}' ",txtNewPwd.Text.Trim());
                sSql.AppendFormat("where LoginId='{0}' and LoginPwd='{1}'",Common.UserName,txtOldPwd.Text.Trim());
                sqlHelper helper = new sqlHelper();
                try
                {
                    if (helper.ExecuteNonQuery(helper.connectionStr, sSql.ToString()) > 0)
                    {
                        MessageBox.Show("密码修改成功！");
                        Common.UserPwd = txtNewPwd.Text.Trim();
                    }
                    else {
                        MessageBox.Show("密码修改失败！");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("系统维护，请稍后再试！",Common.APTION);
                }
            }
        } 
        #endregion

        #region 1.非空验证，2.密码一致性验证
        /// <summary>
        /// 1.不能为空，2.原密码是否正确 3.新旧密码不能相同，4.两次新密码必须一致
        /// </summary>
        /// <returns></returns>
        public bool CheckInput_EditPwd()
        {
            bool flag = false ;
            if(txtOldPwd.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("原密码不能为空！",Common.APTION);
                flag = false;
            }else
            if (txtNewPwd.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("新密码不能为空！", Common.APTION);
                flag = false;
            }else
            if (txtConfirmPwd.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("确认新密码不能为空！", Common.APTION);
                flag = false;
            }else
                if (txtNewPwd.Text.Trim() != txtConfirmPwd.Text.Trim())
                {
                    MessageBox.Show("两次输入新密码不一致！", Common.APTION);
                    flag = false;
                }else if(txtOldPwd.Text.Trim()!=Common.UserPwd)
                {
                    MessageBox.Show("原密码不正确！",Common.APTION);
                    flag = false;
                }
                else if(txtOldPwd.Text.Trim()==txtNewPwd.Text.Trim())
                {
                    MessageBox.Show("新密码不能和原密码相同！", Common.APTION);
                    flag = false;
                }
                else{ flag = true; }
            return flag;
        }
        #endregion

        #region 单列模式方法一：判断窗体状态，如果不为空，将其置空。
        private void FrmEditPwd_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (((FrmAdmin)this.MdiParent).fep != null)
            {
                ((FrmAdmin)this.MdiParent).fep = null;
            }
        } 
        #endregion
    }
}
