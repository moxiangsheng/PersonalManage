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
    public partial class FrmDepartManage : Form
    {
        public FrmDepartManage()
        {
            InitializeComponent();
        }

        #region 窗体加载事件
        private void FrmDeptManager_Load(object sender, EventArgs e)
        {//c查询部门填充到DataGrideView
            QueryDepart();
        }
        #endregion

        #region 事件：查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            QueryDepart();
        }
        #endregion

        #region 事件：添加
        private void btnAddDepart_Click(object sender, EventArgs e)
        {
            FrmAddDept addDept = new FrmAddDept();
            addDept.flag = 1;
            addDept.DeptId = (int)dgvDepart.SelectedRows[0].Cells["deptId"].Value;
            addDept.fdm = this;
            addDept.ShowDialog();
        } 
        #endregion 

        #region 事件：编辑
        private void btnEditDepart_Click(object sender, EventArgs e)
        {
            if(dgvDepart.SelectedRows.Count==1)
            {
                FrmAddDept addDept = new FrmAddDept();
                addDept.flag = 0;
                addDept.DeptId = (int)dgvDepart.SelectedRows[0].Cells["deptId"].Value;
                addDept.DepartName=dgvDepart.SelectedRows[0].Cells["DeptName"].Value.ToString().Trim();
                addDept.fdm = this;
                addDept.ShowDialog();
            }else if(dgvDepart.SelectedRows.Count>1){
                MessageBox.Show("您选择了多个部门，请选择一个修改！");
            }
            else if (dgvDepart.SelectedRows.Count <= 0)
            {
                MessageBox.Show("您没有选择要修改的部门！");
            }
            
        }
        #endregion

        #region 事件：删除
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult delResult = MessageBox.Show("您确定要删除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (delResult == DialogResult.Yes)
            {
                StringBuilder delSb = new StringBuilder();
                foreach (DataGridViewRow row in dgvDepart.SelectedRows)
                {
                    if (row.Cells["deptId"].Value != null)
                    {
                        delSb.Append(row.Cells["deptId"].Value.ToString().Trim());
                        delSb.Append(",");
                    }
                }
                if (delSb.Length == 0)
                {
                    MessageBox.Show("您还没有选择删除项");
                    return;
                }

                delSb.Remove(delSb.Length - 1, 1);
                StringBuilder ExitPoxSb = new StringBuilder();
                ExitPoxSb.Append(" select dept.DeptName from Position pos inner join Depart dept on pos.DeptId=dept.DeptId");
                ExitPoxSb.Append(" where pos.DeptId in (");
                ExitPoxSb.Append(delSb.ToString());
                ExitPoxSb.Append(")");
                ExitPoxSb.Append(" group by dept.DeptName");
                sqlHelper helper = new sqlHelper();
                SqlDataReader dr = helper.ExecuteRead(helper.connectionStr, ExitPoxSb.ToString());
                StringBuilder DeptNameSb = new StringBuilder();
                while (dr.Read())
                {
                    DeptNameSb.Append(dr["DeptName"].ToString().Trim());
                    DeptNameSb.Append(",");
                }
                if (DeptNameSb.Length > 0)
                {
                    DeptNameSb.Remove(DeptNameSb.Length - 1, 1);
                    MessageBox.Show("不能删除！一下的部门正在使用" + DeptNameSb.ToString());
                    return;
                }

                delSb.Insert(0, "delete Depart where DeptId in (");
                delSb.Append(")");

                int result = helper.ExecuteNonQuery(helper.connectionStr, delSb.ToString());
                if (result > 0)
                {
                    MessageBox.Show("删除成功");
                    QueryDepart();
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
            
        } 
        #endregion

        #region 事件：详情
        private void tsmiDeatilDepart_Click(object sender, EventArgs e)
        {
            if (dgvDepart.SelectedRows.Count == 1)
            {
                FrmAddDept addDept = new FrmAddDept();
                addDept.flag = (int)optAED.Detail;
                addDept.DeptId = (int)dgvDepart.SelectedRows[0].Cells["deptId"].Value;
                addDept.ShowDialog();
            }
            else if (dgvDepart.SelectedRows.Count > 1)
            {
                MessageBox.Show("您选择了多个部门，请选择一个查看！");
            }
            else if (dgvDepart.SelectedRows.Count <= 0)
            {
                MessageBox.Show("您没有选择要查看的部门！");
            }
        }
        #endregion

        #region 方法：查询部门
        public void QueryDepart()
        {
            StringBuilder sSql = new StringBuilder();
            sSql.Append("select DeptId,DeptName,parentId from Depart ");
            if (txtDepartName.Text.Trim() != string.Empty)
            {
                sSql.Append("where deptName like '%");
                sSql.Append(txtDepartName.Text.Trim());
                sSql.Append("%' ");
            }
            sSql.Append(" order by DeptId DESC");
            sqlHelper helper = new sqlHelper();
            DataSet ds = helper.ExecuteDataSet(helper.connectionStr, sSql.ToString(), "Depart");
            dgvDepart.AutoGenerateColumns = false;
            dgvDepart.DataSource = ds.Tables["Depart"];

        }
        #endregion

        
        
    }
}
