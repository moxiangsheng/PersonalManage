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
    public partial class FrmEmploryeeManage : Form
    {
        DataSet dsStu;
        public FrmEmploryeeManage()
        {
            InitializeComponent();
        }

        #region 事件：查询
        private void btnQurey_Click_1(object sender, EventArgs e)
        {
            BindEmploryeeinfo();
        } 
        #endregion

        #region 事件：删除
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmploryeeInfo.SelectedRows.Count > 0)
            {


                DialogResult delResult = MessageBox.Show("您确定要删除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (delResult == DialogResult.Yes)
                {

                    //删除语句
                    StringBuilder delSb = new StringBuilder();
                    sqlHelper helper = new sqlHelper();
                    delSb.Append(" UPDATE [hr].[dbo].[Emploryee] SET flag=1 ");
                    delSb.Append(" where EpId in ( ");
                    foreach(DataGridViewRow row in dgvEmploryeeInfo.SelectedRows)
                    {
                        if (row.Cells["EpId"].Value != null)
                        {
                        
                        }
                        delSb.Append(row.Cells["EpId"].Value);
                        delSb.Append(",");
                    }
                    delSb.Remove(delSb.Length-1,1);
                    delSb.Append(" )");

                    int result = helper.ExecuteNonQuery(helper.connectionStr, delSb.ToString());
                    if (result > 0)
                    {
                        MessageBox.Show("删除成功");
                        BindEmploryeeinfo();
                    }
                    else
                    {
                        MessageBox.Show("删除失败");
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择一行");
            }
        } 
        #endregion

        #region 事件：添加
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            FrmAddEmploryee addemp = new FrmAddEmploryee();
            addemp.flag = 1;
            addemp.feb = this;
            addemp.ShowDialog();
        } 
        #endregion

        #region 事件：修改
        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (dgvEmploryeeInfo.SelectedRows.Count != 1)
            {
                MessageBox.Show("只能选择一行");
                return;
            }
            FrmAddEmploryee editemp = new FrmAddEmploryee();
            editemp.flag = 0;
            editemp.feb = this;
            editemp.EmpId = (int)dgvEmploryeeInfo.SelectedRows[0].Cells["EpId"].Value;
            editemp.ShowDialog();
        } 
        #endregion

        #region 事件：详情
        private void tsmiEmploryeeDetail_Click(object sender, EventArgs e)
        {
            if (dgvEmploryeeInfo.SelectedRows.Count != 1)
            {
                MessageBox.Show("只能选择一行查看");
                return;
            }
            FrmAddEmploryee addemp = new FrmAddEmploryee();
            addemp.flag = 2;
            addemp.feb = this;
            addemp.EmpId = (int)dgvEmploryeeInfo.SelectedRows[0].Cells["EpId"].Value;
            addemp.ShowDialog();
        }
        #endregion

        #region 窗体加载事件
        private void FrmEmploryeeManage_Load(object sender, EventArgs e)
        {
            BindEmploryeeinfo();
            Common.BindDept(cmbDepart);
            BindPosition();
        } 
        #endregion

        #region 事件：部门索引变化控制职位的启用
        private void cmbDepart_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbPosition.Enabled = true;
            BindPosition();
        } 
        #endregion

        #region 方法：部门为-1请选择是禁用职位，else启用并根据部门id绑定职位
        protected void BindPosition()
        {
            //职位与部门联动
            if (cmbDepart.SelectedValue.ToString().Trim() == "-1")
            {
                cmbPosition.Enabled = false;
            }
            else
            {
                Common.BindPosition(cmbPosition, (int)cmbDepart.SelectedValue);
                cmbPosition.Enabled = true;
            }
        }
        #endregion

        #region 方法：查询员工
        public void BindEmploryeeinfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select EpId,EpName,case gender when '1' then '男' when '0' then '女' end gender,officePhone,MobilePhone,de.DeptName,po.positionName ");
            sb.Append(" from Emploryee em ,Depart de,Position po ");
            sb.Append("where em.DptId=de.DeptId and em.PId=po.pId ");

            if (txtEmploryeeName.Text.Trim() != string.Empty)
            {
                sb.AppendFormat(" and EpName like '%{0}%' ", txtEmploryeeName.Text.Trim());

            }
            if (rbtBoy.Checked)
            {
                sb.Append(" and [gender]='1' ");
            }
            if (rbtGirl.Checked)
            {
                sb.Append(" and [gender]='0' ");
            }
            if (Convert.ToInt32(cmbDepart.SelectedValue) != 0 && Convert.ToInt32(cmbDepart.SelectedValue) != -1)
            {
                sb.AppendFormat(" and em.DptId={0}", (int)cmbDepart.SelectedValue);    //
            }
            if (Convert.ToInt32(cmbPosition.SelectedValue) != -1 && Convert.ToInt32(cmbPosition.SelectedValue) != 0)
            {
                sb.AppendFormat(" and em.PId={0}", (int)cmbPosition.SelectedValue);
            }
            sb.Append(" and flag= 0 ");
            sqlHelper helper = new sqlHelper();
            dsStu = helper.ExecuteDataSet(helper.connectionStr, sb.ToString(), null);
            dgvEmploryeeInfo.AutoGenerateColumns = false;
            dgvEmploryeeInfo.DataSource = dsStu.Tables[0];


        }
        #endregion

        #region 事件：右键鼠标选中行
        private void dgvEmploryeeInfo_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //dgvEmploryeeInfo.ClearSelection();
                //dgvEmploryeeInfo.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                //dgvEmploryeeInfo.CurrentCell = dgvEmploryeeInfo.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
        } 
        #endregion

        

    }
}
