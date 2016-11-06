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
    public partial class FrmReceiveMessage : Form
    {
        public FrmSendBox frmsb;
        public FrmReceiveMessage()
        {
            InitializeComponent();
        }

        #region 窗体加载事件
        private void FrmReceiveMessage_Load(object sender, EventArgs e)
        {
            Common.BindDept(cmbDept);//绑定部门
            BindPosition();//绑定职位 
            BindAcceptMessage();
            //if(cmbDept.SelectedIndex !=0)
            //{
            //    this.AcceptButton = btnQuery;
            //}
        } 
        #endregion

        #region 查看事件
        private void btnLook_Click(object sender, EventArgs e)
        {
            FrmShowMessage showMessage = new FrmShowMessage();
            if (dgvMessage.SelectedRows.Count == 1)
            {
                showMessage.currentRow = dgvMessage.SelectedRows[0];
                showMessage.frmmessage = this;
                showMessage.ShowDialog();
            }
            else if (this.dgvMessage.SelectedRows.Count > 1)
            {
                MessageBox.Show("您不能同时查看多条消息！", Common.APTION);
            }
            else if (this.dgvMessage.SelectedRows.Count <= 0)
            {
                MessageBox.Show("您没有选择或要查看的项!", Common.APTION);
            }

        }
        #endregion

        #region 单击事件：删除消息
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要删除选中消息吗？", Common.APTION, MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (dgvMessage.SelectedRows.Count > 0)
                {
                    DeleteMessage();
                    BindAcceptMessage();
                }
                else
                {
                    MessageBox.Show("您没有选中要删除的行！", Common.APTION);
                }

            }

        }
        #endregion

        #region 单击事件：未读已读
        /// <summary>
        /// 未读
        /// </summary>
        /// <param name="sender">未读</param>
        /// <param name="e">单击</param>
        private void btnNoRead_Click(object sender, EventArgs e)
        {
            BindNoReadMessage();
        }
        //已读
        private void btnIsRead_Click(object sender, EventArgs e)
        {
            BindIsReadMessage();
        }
        #endregion

        #region 单击事件：查询全部消息加
        private void btnQuery_Click(object sender, EventArgs e)
        {
            BindAcceptMessage();
            
        }
        #endregion

        #region 双击事件：双击单元格查看该条消息详情
        private void dgvMessage_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FrmShowMessage showMessage = new FrmShowMessage();
            if (dgvMessage.SelectedRows.Count == 1)
            {
                showMessage.currentRow = dgvMessage.SelectedRows[0];
                showMessage.frmmessage = this;
                showMessage.ShowDialog();
            }
            else
            {
                MessageBox.Show("您没有选择或要查看的项！");
            }
        }
        #endregion

        #region 方法：动态绑定职位之职位与部门联动
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

        #region 方法：查询全部消息，加载到dgvMessage
        public void BindAcceptMessage()
        {
           
            StringBuilder sSql = new StringBuilder();
            sSql.Append("select MessageId,MessageContent,[AceptEmploryId],[PId],[DptId],EpName,DeptName,positionName,SendTime,[flag], ");
            sSql.Append("case IsRead when 0 then '未读' when 1 then '已读' end as IsRead from vw_AcceptMessage  ");
             //sSql.Append("select MessageId,DeptName,positionName,EpName,MessageContent,SendTime,");
             //sSql.Append("case IsRead when 0 then '未读' when 1 then '已读' end as IsRead ");
             //sSql.Append("from(select EpId,EpName,DeptName,positionName,em.DptId as Dept,em.PId as PId,flag ");  
             //sSql.Append("from Emploryee em,Depart de,Position po "); 
             //sSql.Append("where em.DptId=de.DeptId and em.PId=po.pId ) newEm,Message me ");
             //sSql.Append("where newEm.EpId=me.SendEmploryId ");  
             sSql.AppendFormat(" where AceptEmploryId= {0}", Common.EpId);
            
            if ((int) cmbDept.SelectedValue != 0&&(int)cmbDept.SelectedValue != -1)
            {
                    sSql.Append(" and [DptId]= ");
                    sSql.Append((int)cmbDept.SelectedValue);
                    if ((int)cmbPosition.SelectedValue != 0 && (int)cmbPosition.SelectedValue != -1)
                    {
                        sSql.Append(" and [PId]= ");
                        sSql.Append((int)cmbPosition.SelectedValue);
                    }
            }
            if((int)cmbDept.SelectedValue==0&&(int)cmbPosition.SelectedValue!=-1&&(int)cmbPosition.SelectedValue!=0)
            {
                sSql.AppendFormat(" and [PId]={0} ",(int)cmbPosition.SelectedValue);
            }
            
            if (txtSendName.Text.Trim() != string.Empty)
            {
                sSql.Append(" and EpName like '%");
                sSql.Append(txtSendName.Text.Trim());
                sSql.Append("%'");
            }
            sSql.Append(" and flag=0 ");
            sSql.Append(" order by SendTime desc ");
            sqlHelper helper = new sqlHelper();
            try
            {
                DataSet ds = helper.ExecuteDataSet(helper.connectionStr, sSql.ToString(), "SendEmp");
                dgvMessage.AutoGenerateColumns = false;
                dgvMessage.DataSource = ds.Tables["SendEmp"];
            }
            catch (Exception)
            {

                MessageBox.Show("系统维护！", Common.APTION);
            }    
        } 
        #endregion

        #region 方法：查询未读，已读消息
        /// <summary>
        /// 未读，并按时间排序
        /// </summary>
        public void BindNoReadMessage()
        {
            StringBuilder sSql = new StringBuilder();
            sSql.Append("select MessageId,MessageContent,EpName,DeptName,positionName,SendTime, ");
            sSql.Append("case IsRead when 0 then '未读' when 1 then '已读' end as IsRead from vw_AcceptMessage  ");
            sSql.AppendFormat(" where AceptEmploryId= {0}", Common.EpId);
            sSql.Append(" and IsRead=0");
            sSql.Append(" order by SendTime desc ");
            sqlHelper helper = new sqlHelper();
            DataSet ds = helper.ExecuteDataSet(helper.connectionStr, sSql.ToString(), "NoReadMessage");
            dgvMessage.AutoGenerateColumns = false;
            dgvMessage.DataSource = ds.Tables["NoReadMessage"];
        }
        /// <summary>
        /// 已读，并按时间排序
        /// </summary>
        public void BindIsReadMessage()
        {
            StringBuilder sSql = new StringBuilder();
            sSql.Append("select MessageId,MessageContent,EpName,DeptName,positionName,SendTime, ");
            sSql.Append("case IsRead when 0 then '未读' when 1 then '已读' end as IsRead from vw_AcceptMessage  ");
            sSql.AppendFormat(" where AceptEmploryId= {0}", Common.EpId);
            sSql.Append(" and IsRead=1");
            sSql.Append(" order by SendTime desc ");
            sqlHelper helper = new sqlHelper();
            DataSet ds = helper.ExecuteDataSet(helper.connectionStr, sSql.ToString(), "IsReadMessage");
            dgvMessage.AutoGenerateColumns = false;
            dgvMessage.DataSource = ds.Tables["ISReadMessage"];
        } 
        #endregion

        #region 方法：查询消息
        //public void BindAcceptMessage2()
        //{
        //    sqlHelper helper = new sqlHelper();
        //    StringBuilder sSql = new StringBuilder();
        //    //ssql.Append("select MessageId,DeptName,positionName,EpName,MessageContent,SendTime,");
        //    //ssql.Append(" case IsRead when 0 then '未读' when 1 then '已读' end as IsRead");
        //    //ssql.Append(" from(select EpId,EpName,DeptName,positionName,em.DptId as Dept,em.PId as PId  ");
        //    //ssql.Append(" from Emploryee em,Depart de,Position po ");
        //    //ssql.Append(" where em.DptId=de.DeptId and em.PId=po.pId) newEm,Message me");
        //    //ssql.Append(" where newEm.EpId=me.SendEmploryId  ");
        //    sSql.AppendFormat(" where AceptEmploryId= {0}", Common.EpId);
        //    if (cmbDept.SelectedValue != null)
        //    {
        //        if ((int)cmbDept.SelectedValue != -1 && (int)cmbDept.SelectedValue != 0)
        //        {
        //            sSql.Append(" and DeptId= ");
        //            sSql.Append(cmbDept.SelectedValue.ToString().Trim());


        //            try
        //            {
        //                if ((int)helper.ExecuteNonQuery(helper.connectionStr, sSql.ToString()) <= 0)
        //                {
        //                    MessageBox.Show("没有您要查询的消息！"); return;
        //                }
        //            }
        //            catch (Exception ex)
        //            {

        //                MessageBox.Show(ex.Message);
        //            }
                   
        //        }
        //    }

        //    if (cmbPosition.SelectedValue != null)
        //    {
        //        if ((int)cmbPosition.SelectedValue != -1 && (int)cmbPosition.SelectedValue != 0)
        //        {
        //            sSql.AppendFormat(" and em.PId={0} ", cmbPosition.SelectedValue.ToString().Trim());
        //        }
        //    }
        //    if (txtSendName.Text.Trim() != string.Empty)
        //    {
        //        sSql.AppendFormat(" and EpName like '%{0}%' ", txtSendName.Text.ToString().Trim());
        //    }
        //    sSql.Append(" order by SendTime desc ");
        //    try
        //    {
                
        //        DataSet ds = helper.ExecuteDataSet(helper.connectionStr, sSql.ToString(), "AMessage");
        //        dgvMessage.AutoGenerateColumns = false;
        //        dgvMessage.DataSource = ds.Tables["AMessage"];
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show("电脑已经疯了，请稍后再试！"+"\t"+ex.Message, Common.APTION);
        //    }
        //}
        #endregion

        #region 方法：删除消息
        private void DeleteMessage()
        {
            StringBuilder sSql = new StringBuilder();
            sSql.Append("delete Message where ");
            sSql.Append(" MessageId in(");
            foreach (DataGridViewRow row in dgvMessage.SelectedRows)
            {
                if (row.Cells[0].Value != null)
                {
                    sSql.Append(Convert.ToInt32(row.Cells[0].Value));
                    sSql.Append(",");
                }
            }
            sSql.Remove(sSql.Length - 1, 1);
            sSql.Append(")");
            //sSql.Append(" MessageId =");//删除一条消息
            //if (this.dgvMessage.SelectedRows.Count > 0)
            //{
            //    sSql.Append(Convert.ToInt32(this.dgvMessage.SelectedRows[0].Cells[0].Value));

            //}
            sqlHelper helper = new sqlHelper();
            int number = helper.ExecuteNonQuery(helper.connectionStr, sSql.ToString());
            if (number > 0)
            {
                MessageBox.Show("成 功 删 除 " + number + " 条 消 息！", Common.APTION);
            }
            else
            {
                MessageBox.Show("删除失败！");
            }
        }
        #endregion

        #region 事件：右键鼠标选中行
        private void dgvMessage_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //dgvMessage.ClearSelection();
                //dgvMessage.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                //dgvMessage.CurrentCell = dgvMessage.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
        }
        
        #endregion

        private void FrmReceiveMessage_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (((FrmAdmin)this.MdiParent).frm != null)
            {
                ((FrmAdmin)this.MdiParent).frm = null;
            }
        }
        

    }
}
