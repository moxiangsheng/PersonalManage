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
    public partial class FrmSendMessage : Form
    {
        //public FrmReceiveMessage frmmess;
        public FrmSendMessage()
        {
            InitializeComponent();
        }

        #region 窗体加载事件
        private void FrmSendMessage_Load(object sender, EventArgs e)
        {
            Common.BindDept(cmbDept);//绑定部门
            BindPosition();//绑定职位 
            BindSendEmplory();//绑定数据到DataGridView
        } 
        #endregion

        #region 动态绑定职位之职位与部门联动
        protected void BindPosition()
        {
            //职位与部门联动
            if (cmbDept.SelectedValue.ToString().Trim() == "-1")
            {
                cmbPosition.Enabled = false;
            }
            else
            {
                Common.BindPosition(cmbPosition, (int)cmbDept.SelectedValue);
                cmbPosition.Enabled = true;
            }
        }

        private void cmbDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindPosition();
        }
        #endregion

        #region  查询事件
        private void btnQuery_Click(object sender, EventArgs e)
        {
            BindSendEmplory();
        } 
        #endregion

        #region 查询员工加载到DataGridView
        protected void BindSendEmplory()
        {
            sqlHelper helper = new sqlHelper();
            StringBuilder sSql = new StringBuilder();

            sSql.Append(" select EpId,EpName,case gender when 0 then '女' when 1 then '男' end as Gender,DeptName,positionName ");
            sSql.Append(" from Emploryee em,Depart de,Position po ");
            sSql.Append(" where em.DptId=de.DeptId and em.PId=po.pId  ");
            //sSql.Append(" and po.deptId=de.DeptId ");
            //sSql.Append("select EpId,EpName,case gender when 0 then '女' when 1 then '男' end as Gender,DeptName,positionName");
            //sSql.Append(" FROM [hr].[dbo].[vw_SendEmplory]");
            sSql.Append(" and flag=0 ");

       
            //分步条件加条件筛选信息
            if ((int)cmbDept.SelectedValue != 0 && (int)cmbDept.SelectedValue != -1)
            {
                sSql.Append(" and em.DptId= ");
                sSql.Append((int)cmbDept.SelectedValue);
                if ((int)cmbPosition.SelectedValue != 0 && (int)cmbPosition.SelectedValue != -1)
                {
                    sSql.Append(" and em.pId= ");
                    sSql.Append((int)cmbPosition.SelectedValue);
                }
            }
            if ((int)cmbDept.SelectedValue == 0 && (int)cmbPosition.SelectedValue!= -1&&(int)cmbPosition.SelectedValue!=0)
            {
                sSql.AppendFormat(" and em.pId= {0} ",(int)cmbPosition.SelectedValue);
            }
            if (txtEmploryName.Text.Trim() != string.Empty)
            {
                sSql.Append(" and EpName like '%");
                sSql.Append(txtEmploryName.Text.Trim());
                sSql.Append("%'");
            }
            try
            {
                
                DataSet ds = helper.ExecuteDataSet(helper.connectionStr, sSql.ToString(), "SendEmp");
                dgvEmplory.AutoGenerateColumns = false;
                dgvEmplory.DataSource = ds.Tables["SendEmp"];
            }
            catch (Exception )
            {

                MessageBox.Show("系统维护！",Common.APTION);
            }    
        }
        #endregion

        #region 发送事件
        private void btnSend_Click(object sender, EventArgs e)
        {
            SendMessage();
        } 
        #endregion

        #region 方法：发送消息，创建发送框
        protected void SendMessage()
        {
            StringBuilder EpIds = new StringBuilder();
            StringBuilder EpNames = new StringBuilder();
            //循环从dgvEmploryee获得员工Id,员工姓名，并分别保存至EpIds,EpNames
            foreach (DataGridViewRow row in dgvEmplory.SelectedRows)
            {
                if (row.Cells["EpId"].Value != null)
                {
                    EpIds.Append(row.Cells["EpId"].Value.ToString().Trim());
                    EpIds.Append(",");
                    EpNames.Append(row.Cells["EpName"].Value.ToString().Trim());
                    EpNames.Append(",");
                }
            }
            if (EpIds.Length == 0)
            {
                MessageBox.Show("您没有选择发送者！");
                return;
            }
            EpIds.Remove(EpIds.Length - 1, 1);//获得发送对象的员工Id，
            EpNames.Remove(EpNames.Length - 1, 1);//获得发送对象的员工姓名，
            FrmSendBox sendBox = new FrmSendBox();//创建发送消息框
            sendBox.EpIds = EpIds.ToString();
            sendBox.EpNames = EpNames.ToString();
            sendBox.ShowDialog();//模式窗体展示发送消息框
        }
        #endregion

        #region 右键鼠标时选中行
        private void dgvEmplory_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //dgvEmplory.ClearSelection();
                try
                {
                    //dgvEmplory.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                    //dgvEmplory.CurrentCell = dgvEmplory.Rows[e.RowIndex].Cells[e.ColumnIndex];
                }
                catch (Exception)
                {
                    
                    throw;
                }
            }
        } 
        #endregion


    }
}
