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
    public partial class FrmAddDept : Form
    {
        public FrmAddDept()
        {
            InitializeComponent();
        }
        public FrmDepartManage fdm;
        public int flag=0;//0编辑，1添加，2详情
        public int DeptId;
        public string DepartName;

        #region 窗体加载事件
        private void FrmAddDept_Load(object sender, EventArgs e)
        {
            Common.BindDept(cmbDepartFather);
            switch (flag)
            {
                case 0:
                    this.Text = "编辑部门";
                    lblDepartId.Visible = txtDepartId.Visible = true;
                    txtDepartId.Text = DeptId.ToString().Trim();
                    //txtDeptName.Text = DepartName.Trim();
                    showDept();
                    btnAddDept.Text = "保存";
                    break;
                case 1:
                    this.Text = "添加部门";

                    lblDepartId.Visible = txtDepartId.Visible = false;
                    txtDepartId.ReadOnly = true;
                    
                    break;
                default:
                    this.Text = "查看详情";
                    lblDepartId.Visible =txtDepartId.Visible= true;
                    txtDeptName.Enabled = cmbDepartFather.Enabled = false;;
                    btnAddDept.Enabled = false;
                    showDept();
                    break;
            }
        }
        #endregion

        #region 事件：添加
        private void btnAddDept_Click(object sender, EventArgs e)
        {
            if (CheckInput_AddDept())
            {
                if(flag==1)
                {//添加部门
                    AddDepart();
                }
                else if (flag == 0)
                {//编辑部门
                    EditDepart();
                }
                else if (flag == 2)
                {//部门详情
                    showDept();
                }
                
            }
        } 
        #endregion

        #region 事件：取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 方法：添加部门
        private void AddDepart()
        {
            StringBuilder sSql = new StringBuilder();
            sSql.Append("insert into Depart (DeptName,parentId) ");
            sSql.AppendFormat("values ('{0}',{1})", txtDeptName.Text.Trim(), cmbDepartFather.SelectedValue.ToString().Trim());
            sqlHelper helper = new sqlHelper();
            try
            {
                if (helper.ExecuteNonQuery(helper.connectionStr, sSql.ToString()) > 0)
                {
                    MessageBox.Show("添加成功！", Common.APTION);
                    fdm.QueryDepart();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("添加失败！", Common.APTION);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("系统维护，请稍后再试！", Common.APTION);
            }
        } 
        #endregion

        #region 方法：编辑部门
        private void EditDepart()
        {
            StringBuilder sSql = new StringBuilder();
            sSql.AppendFormat("update Depart set DeptName= '{0}', ", txtDeptName.Text.Trim());
            sSql.AppendFormat(" parentId={0} ",(int)cmbDepartFather.SelectedValue);
            sSql.AppendFormat(" where DeptId={0}",Convert.ToInt32(txtDepartId.Text.Trim()));
            sqlHelper helper = new sqlHelper();
            try
            {
                if (helper.ExecuteNonQuery(helper.connectionStr, sSql.ToString()) > 0)
                {
                    MessageBox.Show("修改成功！", Common.APTION);
                    fdm.QueryDepart();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败！", Common.APTION);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("系统维护，请稍后再试！", Common.APTION);
            }
        }
        #endregion

        #region 方法：展示部门详情
        private void showDept()
        {
            //StringBuilder sSql=new StringBuilder();
            //sSql.Append("select de.DeptId,de.DeptName,pn.DeptName ");
            //sSql.Append(" from(select DeptName from Depart where DeptId= ");
            //sSql.AppendFormat(" (select parentId from Depart where DeptId={0})) pn, Depart de ",DeptId);
            //sSql.AppendFormat(" where DeptId={0} ",DeptId);
            string sSql = "select * from Depart where DeptId="+DeptId;
            sqlHelper helper = new sqlHelper();
            SqlDataReader dr = helper.ExecuteRead(helper.connectionStr, sSql);
            if (dr.Read())
            {

                cmbDepartFather.SelectedValue = (int)dr["parentId"];
                txtDeptName.Text = dr["DeptName"].ToString().Trim();
                if (flag == 2)
                {
                    txtDepartId.Text = DeptId.ToString().Trim();
                }
            }
            dr.Close();
        }
        #endregion

        //#region 动态绑定部门
        //protected void BindDept()
        //{
        //    string sSql = "select DeptId,DeptName from Depart ";
        //    sqlHelper helper = new sqlHelper();
        //    DataSet ds = helper.ExecuteDataSet(helper.connectionStr,sSql,"Depart");
        //    DataRow row=ds.Tables["Depart"].NewRow();
        //    row[0]=0;
        //    row[1]="所有部门";
        //    ds.Tables["Depart"].Rows.InsertAt(row, 0);
        //    DataRow row1=ds.Tables["Depart"].NewRow();
        //    row1[0]=-1;
        //    row1[1]="请选择";
        //    ds.Tables["Depart"].Rows.InsertAt(row1,0);
        //    cmbDepart.DisplayMember = "DeptName";
        //    cmbDepart.ValueMember = "DeptId";
        //    cmbDepart.DataSource=ds.Tables["Depart"];
        //}
        //#endregion

        #region 输入验证，非空
        protected bool CheckInput_AddDept()
        { 
            if(cmbDepartFather.SelectedValue.ToString().Trim()=="-1")
            {
                MessageBox.Show("请选择上级部门！",Common.APTION);
                return false;
            }
            else if (txtDeptName.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入部门名！", Common.APTION);
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

  

        
    }
}
