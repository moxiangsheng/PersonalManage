using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace PersonnelManage
{
    public partial class FrmLogin : Form
    {
        Sunisoft.IrisSkin.SkinEngine se;
        Secret Sc = new Secret();
        public FrmLogin()
        {
            InitializeComponent();//设计器Designer
            se = new Sunisoft.IrisSkin.SkinEngine();
            //se.SkinAllForm = true;//所有窗体均应用此皮肤
            se.SkinFile = "skin/skin.ssk";//加载初始化皮肤风格
        }

        #region 窗体加载事件：1.登录类型加载
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //加载登录类型索引0位置：请选择
            this.cmbLoginType.SelectedIndex = 0;
        }
        #endregion

        #region 登录事件（管理员，学员，游客）
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckInput_Login())
            {
                if (cmbLoginType.Text.Trim().Equals("管理员"))
                {
                    if (CheckAdmin())
                    {
                        FrmAdmin admin = new FrmAdmin();
                        admin.Show();
                        admin.se = se;
                        this.Hide();
                    }
                    else {
                        MessageBox.Show(Common.Message);
                    }
                } 
                if(cmbLoginType.Text.ToString().Trim().Equals("学员")){
                    MessageBox.Show("学员尚未开放，敬请期待！",Common.APTION);
                }
                 if (cmbLoginType.Text.Trim().Equals("游客"))
                {
                    MessageBox.Show("游客尚未开放，敬请期待！",Common.APTION);
                }
            }

        } 
        #endregion

        #region 取消事件
        private void btnCancle_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认退出该系统吗？","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(result==DialogResult.Yes)
            {
                Application.Exit();
            }
        } 
        #endregion

        #region 注册事件
        private void bRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show("不接受在线注册！\n如需注册请与开发商联系！GC版权所有。", "温馨提示！");
        } 
        #endregion

        #region 连接数据库，验证管理员登录方法，返回true,false;
        private bool CheckAdmin()
        {
            bool isValidAdmin = false;
            Common.UserName = cmbUserName.Text.Trim();
            Common.UserPwd = txtUserPwd.Text.Trim();
            
            StringBuilder sSql = new StringBuilder();
            sSql.Append("select LoginId,LoginPwd,us.epId,ep.EpName from Users us inner join Emploryee ep on us.epId=ep.epId ");
            sSql.AppendFormat("where LoginId='{0}' and LoginPwd='{1}'", cmbUserName.Text.Trim (), txtUserPwd.Text.Trim());
            sSql.Append(" and ep.flag=0 ");
            sqlHelper helper = new sqlHelper();
            try
            {
                SqlDataReader dr = helper.ExecuteRead(helper.connectionStr, sSql.ToString());
                
                if (dr.Read())
                {
                    Common.EpId = Convert.ToInt32(dr["epId"]);
                    Common.EpName = dr["EpName"].ToString().Trim() ;
                    if (dr["LoginId"].ToString().Trim() == Common.UserName && dr["LoginPwd"].ToString().Trim() == Common.UserPwd)
                    {
                        isValidAdmin = true;
                    }
                    else
                    {
                        Common.Message = "用户名或密码不正确！";
                        isValidAdmin = false;
                    }
                } dr.Close();
            }
            catch (Exception)
            {
                Common.Message = "系统维护，请稍后再试！";
                isValidAdmin = false;
            }
            
            return isValidAdmin;
        } 
        #endregion

        #region 非空验证，返回true,false;
        private bool CheckInput_Login()
        {
            bool flag = false;
            if (cmbUserName.Text.Trim().Equals("请输入用户名") || cmbUserName.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入用户名！", Common.APTION, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtUserPwd.Text.Trim().Equals("密码") || cmbUserName.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入密码！", Common.APTION, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cmbLoginType.Text.Trim().Equals("请选择"))
            {
                MessageBox.Show("请选择登录类型！", Common.APTION, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else { flag = true; }
            return flag;
        }
        #endregion

        #region 注册方法
        private void Register()
        {

        } 
        #endregion

        #region 事件：显示组合框下拉列表时发生
        private void cmbUserName_DropDown(object sender, EventArgs e)
        {
            cmbUserName.Items.Clear();
            CombBox_Load(".//Record_User_Info//User_Info.ini", cmbUserName);
        } 
        #endregion

        #region 方法：下拉列表读取
        public void CombBox_Load(string File_path, ComboBox CombBox_List)
        {
            try
            {
                if (File.ReadAllText(File_path, Encoding.UTF8) != "") //[判断] [用户信息文件内容不为空]
                {
                    try
                    {
                        string[] Temp_String = File.ReadAllLines(File_path, Encoding.UTF8);
                        for (int i = 0; i < Temp_String.Length; i++)
                        {
                            CombBox_List.Items.Add(Sc.Fun_UnSecret(Temp_String[i]));
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.ToString());
                    }
                }
            }
            catch
            {

            }
        }
        #endregion

        #region 事件：用户名，密码输入框提示转换
        private void cmbUserName_Enter(object sender, EventArgs e)
        {
            if (cmbUserName.Text == "请输入用户名")
            {
                cmbUserName.Text = "";
                cmbUserName.ForeColor = Color.Black;
            }
        }

        private void cmbUserName_Leave(object sender, EventArgs e)
        {
            if (cmbUserName.Text == "")
            {
                cmbUserName.Text = "请输入用户名";
                cmbUserName.ForeColor = Color.Silver;
            }
        } 
        
        private void txtUserPwd_Enter(object sender, EventArgs e)
        {
            if (txtUserPwd.Text == "密码")
            {
                txtUserPwd.Text = "";
                txtUserPwd.PasswordChar = char.Parse("●");//PasswordChar设置
                txtUserPwd.ForeColor = Color.Black;
            }
        }

        private void txtUserPwd_Leave(object sender, EventArgs e)
        {
            if (txtUserPwd.Text == "")
            {
                txtUserPwd.Text = "密码";
                txtUserPwd.PasswordChar='\0'; //清空PasswordChar设置
                txtUserPwd.ForeColor = Color.Silver;
            }
        }
        #endregion
    }
}
