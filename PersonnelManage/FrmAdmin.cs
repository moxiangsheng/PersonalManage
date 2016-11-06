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
    public partial class FrmAdmin : Form
    {
        public Sunisoft.IrisSkin.SkinEngine se;
        public FrmLogin frmlogin;//登录
        public FrmSendMessage fsm;//发送消息
        public FrmReceiveMessage frm;//接收消息
        public FrmEditPwd fep;//修改密码
        public FrmAddEmploryee frmAddEmporyee;//添加员工
        public FrmEmploryeeManage frmEmpmag;//员工管理
        public FrmAddDept fad;//添加部门
        public FrmDepartManage fdm;//部门管理
        public FrmMessageBox frmmbox;//消息框
        public FrmAbout frmabout;//关于
        public FrmLock frmlock;//锁定
        public FrmAssessExample frmAssExa;//考核模板
        public FrmAssessManage frmAssMag;//考核管理
        public FrmAdmin()
        {
            InitializeComponent();
        }

        #region 窗体加载事件：加载窗体Text为当前用户，设置MDI背景
        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            //this.Text = "-欢迎使用人事管理系统：" + Title();
            this.Text = "欢迎使用GC攻城人事管理系统：" + Common.EpName;
            validateMessage();
            RemoveMdiBackColor();


        }
        /// <summary>
        /// 设置MDI背景
        /// </summary>
        void RemoveMdiBackColor()
        {
            foreach (Control c in this.Controls)
            {
                if (c is MdiClient)
                {
                    //c.BackColor = Color.LightGray;   //颜色 
                    c.BackgroundImage = this.BackgroundImage;   //背景 
                }
            }
        }
        #endregion

        #region 方法：判断子窗体是否存在，true为存在//false为空
        private bool hasFrom(Form myForm)
        {
            bool bHasForm = false;
            foreach (Form form in MdiChildren)
            {
                if (form.Equals(myForm))
                {
                    bHasForm = true;
                }
            }
            return bHasForm;
        }
        #endregion  

        #region 事件：退出
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region 事件：修改密码
        private void tsmiEditPwd_Click(object sender, EventArgs e)
        {
            if (fep==null)
            {
                fep = new FrmEditPwd();
                fep.MdiParent = this;
                fep.Show();
            }
        }
        #endregion

        #region 事件：添加员工
        private void tsmiAddEmploryee_Click(object sender, EventArgs e)
        {
            if (!hasFrom(frmAddEmporyee))
            {
                frmAddEmporyee = new FrmAddEmploryee();
                frmAddEmporyee.MdiParent = this;
                frmAddEmporyee.flag = 1;
                frmAddEmporyee.Show();
            }
        } 
        #endregion

        #region 事件：员工管理
        private void tsmiEmploryeeManage_Click(object sender, EventArgs e)
        {
            if(!hasFrom(frmEmpmag))
            {
                frmEmpmag =new FrmEmploryeeManage();
                frmEmpmag.MdiParent = this;
                frmEmpmag.Show();
            }
        }
        #endregion

        #region 事件：添加部门
        private void tsmiAddDept_Click(object sender, EventArgs e)
        {
            if (!hasFrom(fad))
            {
                fad = new FrmAddDept();
                fad.MdiParent = this;
                fad.flag = 1;
                fad.Show();
            }
        } 
        #endregion

        #region 事件：部门管理
        private void tsmiDeptManage_Click(object sender, EventArgs e)
        {
            if(!hasFrom(fdm))
            {
                fdm = new FrmDepartManage();
                fdm.MdiParent = this;
                fdm.Show();
            }
        } 
        #endregion

        #region 事件：发送短消息
        private void tsmiSendMessage_Click(object sender, EventArgs e)
        {
            if (!hasFrom(fsm))
            {
                fsm = new FrmSendMessage();
                fsm.MdiParent = this;
                fsm.Show();
            }
        }
        #endregion

        #region 事件：接收短消息
        private void tsmiReceiveMessage_Click(object sender, EventArgs e)
        {
            if(frm==null)
            {
                frm = new FrmReceiveMessage();
            }
                frm.MdiParent = this;
                frm.Show();
            
        }
        #endregion

        #region 事件：考核模板
        private void tsmiAccessExample_Click(object sender, EventArgs e)
        {
            if (!hasFrom(frmAssExa))
            {
                frmAssExa = new FrmAssessExample();
                frmAssExa.MdiParent = this;
                frmAssExa.Show();
            }
        }
        #endregion

        #region 事件：考核管理
        private void tsmiAssessManage_Click(object sender, EventArgs e)
        {
            if (!hasFrom(frmAssMag))
            {
                frmAssMag = new FrmAssessManage();
                frmAssMag.MdiParent = this;
                frmAssMag.Show();
            }
        }
        #endregion

        #region 计时器事件1：查询当前用户未读消息，有未读则Message窗体提示
        private void timer1_Tick(object sender, EventArgs e)
        {
            validateMessage();
        }
        #endregion

        #region 计时器事件2：北京时间
        private void timer2_Tick(object sender, EventArgs e)
        {
            lblTime.Text = "当前用户："+Common.EpName + "      北京时间：" + DateTime.Now.Year + "年"
                       + DateTime.Now.Month + "月"
                       + DateTime.Now.Day + "日"
                       + DateTime.Now.Hour + "点"
                       + DateTime.Now.Minute + "分"
                       + DateTime.Now.Second + "秒";
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            if (!hasFrom(frmabout))
            {
                frmabout = new FrmAbout();
                frmabout.ShowDialog();
            }
        }
        #endregion

        #region 事件：风格样式
        //默认蓝魅
        private void tsmiDefault_Click(object sender, EventArgs e)
        {
            //se.SkinAllForm = true;//所有窗体均应用此皮肤
            se.SkinFile = "skin/skin.ssk";
        }
        //绿色家园
        private void tsmiBlueStyle_Click(object sender, EventArgs e)
        {
            se.SkinFile = "skin/DiamondGreen.ssk";
        }
        //MacOS
        private void tsmiMacOSStyle_Click(object sender, EventArgs e)
        {
            se.SkinFile = "skin/MacOS.ssk";
        }
        //蓝色波浪
        private void tsmiBuleWaveStyle_Click(object sender, EventArgs e)
        {
            se.SkinFile = "skin/wave.ssk";
        }
        //灰色轨迹
        private void tsmiGrayRowStyle_Click(object sender, EventArgs e)
        {
            se.SkinFile = "skin/Eighteen.ssk";
        }

        #endregion

        #region 事件：锁定
        private void tsbtnLock_Click(object sender, EventArgs e)
        {
            if (!hasFrom(frmlock))
            {
                frmlock = new FrmLock();
                frmlock.ShowDialog();
            }
        }
        #endregion

        #region 方法：查询当前用户未读消息方法，有未读则MessageBox窗体提示
        private void validateMessage()
        {
            string sSql = "select count(*) from Message where IsRead=0 and AceptEmploryId=" + Common.EpId;
            sqlHelper helper = new sqlHelper();
            if ((int)helper.ExecuteScalar(helper.connectionStr, sSql) > 0)
            {
                if (frmmbox == null)
                {
                    frmmbox = new FrmMessageBox();
                    frmmbox.frmadmin = this;
                    frmmbox.frmrm = frm;
                    frmmbox.Show();
                }
            }
            else
            {
                if (frmmbox != null)
                {
                    frmmbox.Close();
                    frmmbox = null;
                }
            }
        }
        #endregion

        #region 查询当前用户并返回
        //protected string Title()
        //{
        //    string title = null;
        //    String sSql = "select EpName from Emploryee where EpId in (select epId from Users where LoginId ='admin' and LoginPwd='admin' ) ";
        //    sqlHelper helper = new sqlHelper();
        //    SqlDataReader dr = helper.ExecuteRead(helper.connectionStr, sSql);
        //    if (dr.Read())
        //    {
        //        title = dr["EpName"].ToString().Trim();
        //    }
        //    return title;
        //} 
        #endregion

        #region 事件：关闭窗体后发生退出系统
        private void FrmAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region 事件：工具栏隐藏
        private void tsmiToolStripMenu_Click(object sender, EventArgs e)
        {
            if (toolStrip1.Visible == false)
                toolStrip1.Show();
            else
                toolStrip1.Hide();
        } 
        #endregion

        #region 事件：状态栏隐藏
        private void tsmiStutasBar_Click(object sender, EventArgs e)
        {
            if (lblTime.Visible == false)
            {
                lblTime.Show();
            }
            else
            {
                lblTime.Hide();
            }
        }
        
        #endregion

        #region 事件：窗体快捷键设置
        private void FrmAdmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                if (WindowState == FormWindowState.Maximized)
                {
                    WindowState = FormWindowState.Normal;
                }
                else
                {
                    WindowState = FormWindowState.Maximized;
                }
            }
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.F1)
            {
                if (!hasFrom(frmlock))
                {
                    frmlock = new FrmLock();
                    frmlock.frmLock = frmlock;
                    frmlock.ShowDialog();
                }
            }
        } 
        #endregion
        

        

        

    }
}
