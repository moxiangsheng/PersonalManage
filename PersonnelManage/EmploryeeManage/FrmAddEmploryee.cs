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
    public partial class FrmAddEmploryee : Form
    {
        public int flag ;//0表示编辑，1表示添加,2表示详情
        public FrmEmploryeeManage feb;
        public int EmpId;

        public FrmAddEmploryee()
        {
            InitializeComponent();
        }

        #region 窗体加载事件：1.加载部门 2.加载职位
        private void FrmAddEmploryee_Load(object sender, EventArgs e)
        {
            Common.BindAllDepart(cmbDepart);//绑定部门
            BindPosition();//绑定职位
            switch (flag)
            {
                case 0:
                    this.Text = "编辑员工信息";
                    showEmploryee();
                    btnAdd.Text = "保存";
                    break;
                case 1:
                    this.Text = "添加新员工";
                    break;
                case 2:
                    this.Text = "查看详情";
                    btnAdd.Enabled = btnClear.Enabled= false;

                    foreach (Control ct in this.Controls)
                    {
                        if (ct is GroupBox)
                        {
                            GroupBox gb = (GroupBox)ct;
                            foreach (Control gct in gb.Controls)
                            {
                                if (gct is TextBox)
                                {
                                    ((TextBox)gct).Enabled = false ;
                                }
                            }
                        }
                    }
                    cmbDepart.Enabled = false;
                    cmbPosition.Enabled = false;

                    showEmploryee();
                    break;
            }
        }
        #endregion

        #region 方法：查看员工详情
        protected void showEmploryee()
        {
            StringBuilder sSql = new StringBuilder();
            sSql.Append(" select * from Emploryee ");
            sSql.AppendFormat("where EpId={0}", EmpId);
            sqlHelper helper = new sqlHelper();
            SqlDataReader dr = helper.ExecuteRead(helper.connectionStr, sSql.ToString());
            if (dr.Read())
            {
                txtEmploryeeName.Text = dr["EpName"].ToString().Trim();
                switch (dr["gender"].ToString().Trim())
                {
                    case "1":
                        this.rbtBoy.Checked = true;
                        break;
                    case "0":
                        this.rbtGirl.Checked = true;
                        break;
                }
                txtCellPhoneNum.Text = dr["MobilePhone"].ToString().Trim();
                txtTelephoneNum.Text = dr["officePhone"].ToString().Trim();
                txtAddress.Text = dr["Address"].ToString().Trim();
                cmbDepart.SelectedValue = (int)dr["DptId"];
                cmbPosition.SelectedValue = (int)dr["PId"];
            }
            dr.Close();
        } 
        #endregion

        #region 事件：部门索引改变时发生
        private void cmbDepart_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindPosition();
        }
        #endregion

        #region 事件：清空
        private void btnCancle_Click(object sender, EventArgs e)
        {
            //foreach (Control ct in this.Controls)
            //{
            //    if (ct is GroupBox)
            //    {
            //        GroupBox gb = (GroupBox)ct;
            //        foreach (Control gct in gb.Controls)
            //        {
            //            if (gct is TextBox)
            //            {
            //                ((TextBox)gct).Text = string.Empty;
            //            }
            //        }
            //    }
            //}
            txtAddress.Text = txtCellPhoneNum.Text = txtEmploryeeName.Text = txtTelephoneNum.Text = null;
            rbtBoy.Checked = true;
            cmbDepart.SelectedValue = 0;
            cmbPosition.SelectedValue = 0;
        } 
        #endregion

        #region 事件：添加员工
        private void btnAdd_Click(object sender, EventArgs e)
        {
           if(CheckInput())
           {
               if(flag==1)
               {
                AddEmploryee();
               }
               if(flag==0)
               {
                   updataEmploryee();
               }
               
           }
        }
        #endregion

        #region 方法：更新员工信息
        private void updataEmploryee()
        {
            StringBuilder sSql = new StringBuilder();
            sSql.Append("update Emploryee set  ");
            sSql.AppendFormat(" EpName='{0}',", txtEmploryeeName.Text.Trim());
            if (rbtBoy.Checked)
            {
                sSql.AppendFormat(" gender={0},", 1);
            }
            else
            {
                sSql.AppendFormat(" gender={0},", 0);
            }
            sSql.AppendFormat(" MobilePhone='{0}', ", txtCellPhoneNum.Text.Trim());
            sSql.AppendFormat(" officePhone='{0}',", txtTelephoneNum.Text.Trim());
            sSql.AppendFormat(" Address='{0}', ", txtAddress.Text.Trim());
            sSql.AppendFormat(" DptId={0},", (int)cmbDepart.SelectedValue);
            sSql.AppendFormat(" PId={0} ", (int)cmbPosition.SelectedValue);
            sSql.AppendFormat(" where EpId={0} ", EmpId);
            sqlHelper helper = new sqlHelper();
            try
            {
                if (helper.ExecuteNonQuery(helper.connectionStr, sSql.ToString()) > 0)
                {
                    MessageBox.Show("修改保存成功！", Common.APTION);
                    this.Close();
                    feb.BindEmploryeeinfo();
                }
                else
                {
                    MessageBox.Show("修改失败！", Common.APTION);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("系统维护！");
            }

        } 
        #endregion

        #region 方法：添加员工
        private void AddEmploryee()
        {

            StringBuilder sSql = new StringBuilder();
            sSql.Append("insert Emploryee (EpName,PId,DptId,MobilePhone,officePhone,Address,gender) ");
            sSql.AppendFormat(" values('{0}',", txtEmploryeeName.Text.Trim());
            sSql.AppendFormat("{0},", cmbPosition.SelectedValue);
            sSql.AppendFormat("{0},", cmbDepart.SelectedValue);
            sSql.AppendFormat("'{0}',", txtCellPhoneNum.Text.Trim());
            sSql.AppendFormat("'{0}',", txtTelephoneNum.Text.Trim());
            sSql.AppendFormat("'{0}',", txtAddress.Text.Trim());
            if (rbtBoy.Checked)
            {
                sSql.AppendFormat("{0}", 1);
            }
            else if (rbtGirl.Checked)
            {
                sSql.AppendFormat("{0}", 0);
            }
            sSql.Append(")");
            sqlHelper helper = new sqlHelper();
            try
            {
                if (helper.ExecuteNonQuery(helper.connectionStr, sSql.ToString()) > 0)
                {
                   
                    MessageBox.Show("添加成功！");
                    feb.BindEmploryeeinfo();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("添加失败！");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("系统维护！");
            }
        }  
        #endregion
        
        #region 方法：部门与职位联动
        private void BindPosition()
        {
            if (cmbDepart.SelectedValue.ToString().Trim() == "0")
            {
                cmbPosition.Enabled = false;
            }
            else
            {
                Common.BindAllPosition(cmbPosition, (int)cmbDepart.SelectedValue);
                cmbPosition.Enabled = true;
            }
        }
        #endregion

        #region 方法：检查输入合法性
        public bool CheckInput()
        { 
            bool flag=false;
            if(txtEmploryeeName.Text.ToString().Trim()=="")
            {
                MessageBox.Show("请输入员工姓名！",Common.APTION,MessageBoxButtons.OK);
                flag = false;
            }
            else if (txtCellPhoneNum.Text.ToString().Trim() == "")
            {
                MessageBox.Show("请输入手机号码！", Common.APTION, MessageBoxButtons.OK);
                flag = false;
            }
            else if (txtTelephoneNum.Text.ToString().Trim() == "")
            {
                MessageBox.Show("请输入工作电话！", Common.APTION, MessageBoxButtons.OK);
                flag = false;
            }
            else if (txtAddress.Text.ToString().Trim() == "")
            {
                MessageBox.Show("请输入地址！", Common.APTION, MessageBoxButtons.OK);
                flag = false;
            }
            else 
                if(cmbDepart.Text.ToString().Trim().Equals("请选择"))
            {
                MessageBox.Show("请选择部门！",Common.APTION,MessageBoxButtons.OK);
                flag = false;
            }else
                if(cmbPosition.SelectedValue.ToString().Trim().Equals("0"))
            {
                MessageBox.Show("请选择职位！",Common.APTION,MessageBoxButtons.OK);
                flag = false;
            }else
             {
                 if (!Common.IsFloat(txtCellPhoneNum.Text))
                 {
                     MessageBox.Show("手机号为11位数字！");
                     flag = false;
                 }
                 else
                 {
                     flag = true;
                 }
                }
            return flag;
        }
        #endregion
    
    }
}
