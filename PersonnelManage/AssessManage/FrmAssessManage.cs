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
    public partial class FrmAssessManage : Form
    {
        DataSet ds;
        public int EmploryId;

        public FrmAssessManage()
        {
            InitializeComponent();
        }

        #region 窗体加载事件
        private void FrmAssessManage_Load(object sender, EventArgs e)
        {
            GetEnable(false);
            Common.BindDept(cmbDept);
            bindPos();
            if (dptAssessMonth.Value.Year != DateTime.Now.Year || dptAssessMonth.Value.Month != DateTime.Now.Month)
            {
                GetEnable(false);
            }
            else
            {
                GetEnable(true);
            }
        } 
        #endregion

        private void GetEnable(bool IsGurrentDate)
        {
            btnAdd.Enabled = btnDelete.Enabled = btnInput.Enabled = btnSave.Enabled = btnShow.Enabled = IsGurrentDate;

        }

        #region 方法：绑定职位
        protected void bindPos()
        {
            if (cmbDept.SelectedValue.ToString().Trim() == "-1")
            {
                cmbPos.Enabled = false;
                cmbEpName.Enabled = false;

            }
            else
            {
                Common.BindPosition(cmbPos, (int)cmbDept.SelectedValue);
                cmbPos.Enabled = true;
                cmbEpName.Enabled = true;
            }
        } 
        #endregion

        #region 方法：根据员工获取总分数
        /// <summary>
        /// 获取总分数
        /// </summary>
        public void BindAssess()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select EmploerId,AssessId,EpName,EmploerId,AssesContent,Score,SelfScore,LeaderScore,Remark from vw_Assess where flag=0");
            if ((int)cmbEpName.SelectedValue != -1)
            {
                sb.Append(" and EmploerId=");
                EmploryId = int.Parse(cmbEpName.SelectedValue.ToString().Trim());
                sb.Append(EmploryId);
            }
            else
            {
                //MessageBox.Show("请选择员工");
                if (ds != null)
                {
                    if (ds.Tables[0] != null)
                    {
                        ds.Tables[0].Rows.Clear();
                    }
                    else
                    {
                        dgvAssess.Rows.Clear();
                    }
                }
                return;
            }
            string assessTime = dptAssessMonth.Value.Year + "-" + dptAssessMonth.Value.Month;
            sb.Append(" and AssessMonth='");
            sb.Append(assessTime);
            sb.Append("'");
            ds = Common.helper.ExecuteDataSet(Common.helper.connectionStr, sb.ToString(), "Assess");
            dgvAssess.AutoGenerateColumns = false;
            dgvAssess.DataSource = ds.Tables[0];
            getTotalScore();
            getSelfScore();
            getFinalScore();
        }
        #endregion

        #region 计算最后总分
        protected void getTotalScore()
        {
            double sum = 0;
            foreach (DataGridViewRow row in dgvAssess.Rows)
            {
                if (row.Cells["Score"].Value != null)
                {
                    sum += (double)row.Cells["Score"].Value;
                }
            }
            lblTotalScore.Text = "考核总分：" + sum;
        }
        protected void getSelfScore()
        {
            double sum = 0;
            foreach (DataGridViewRow row in dgvAssess.Rows)
            {
                if (row.Cells["SelfScore"].Value != null)
                {
                    sum += (double)row.Cells["SelfScore"].Value;
                }
            }
            lblSelfScore.Text = "自评得分：" + sum;
        }

        protected void getFinalScore()
        {
            double sum = 0;
            foreach (DataGridViewRow row in dgvAssess.Rows)
            {
                if (row.Cells["LeaderScore"].Value != null)
                {
                    sum += (double)row.Cells["LeaderScore"].Value;
                }
            }
            lblFinalScore.Text = "最终得分：" + sum;
        }
        #endregion

        #region 事件：添加
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbEpName.SelectedValue != null && (int)cmbEpName.SelectedValue != 0)
            {
                FrmSingleAssess InputAssess = new FrmSingleAssess();
                InputAssess.asses = this;
                InputAssess.AssesTime = dptAssessMonth.Value.Year + "-" + dptAssessMonth.Value.Month;
                InputAssess.EmploryId = EmploryId;
                InputAssess.ShowDialog();
            }
            else
            {
                MessageBox.Show("您还没有选择要考核的员工");
            }
        } 
        #endregion

        #region 事件：导入
        private void btnInput_Click(object sender, EventArgs e)
        {
            if (cmbEpName.SelectedValue != null && (int)cmbEpName.SelectedValue != 0)
            {
                FrmInputAssessExample InputAssess = new FrmInputAssessExample();
                InputAssess.asses = this;
                InputAssess.AssesTime = dptAssessMonth.Value.Year + "-" + dptAssessMonth.Value.Month;
                InputAssess.EmploryId = EmploryId;
                InputAssess.ShowDialog();
            }
            else
            {
                MessageBox.Show("您还没有选择要考核的员工");
            }
        } 
        #endregion

        #region 事件：删除
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要删除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                StringBuilder sb = new StringBuilder();
                foreach (DataGridViewRow row in dgvAssess.SelectedRows)
                {
                    sb.Append(row.Cells["AssessId"].Value);
                    sb.Append(",");
                }

                if (sb.Length == 0)
                {
                    MessageBox.Show("您还没有选择要删除的内容");
                    return;
                }

                sb.Remove(sb.Length - 1, 1);
                sb.Insert(0, " delete Assess where AssessId in (");
                sb.Append(")");

                if (Common.helper.ExecuteNonQuery(Common.helper.connectionStr, sb.ToString()) > 0)
                {
                    BindAssess();
                    MessageBox.Show("删除成功");
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
        } 
        #endregion

        #region 事件：保存
        private void btnSave_Click(object sender, EventArgs e)
        {
            int result = 0;
            foreach (DataGridViewRow row in dgvAssess.SelectedRows)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(" update [Assess]");
                sb.AppendFormat(" set [EmploerId]={0}", EmploryId);
                sb.AppendFormat(" ,[AssesContent]='{0}'", row.Cells["AssesContent"].Value.ToString().Trim());
                sb.AppendFormat(" ,[Score]='{0}'", row.Cells["Score"].Value.ToString().Trim());
                sb.AppendFormat(" ,[SelfScore]={0}", row.Cells["SelfScore"].Value.ToString().Trim());
                sb.AppendFormat(" ,[LeaderScore]={0}", row.Cells["LeaderScore"].Value.ToString().Trim());
                sb.AppendFormat(" ,[AssessMonth]='{0}'", dptAssessMonth.Value.Year + "-" + dptAssessMonth.Value.Month);
                sb.AppendFormat(" ,[Remark]='{0}'", row.Cells["Remark"].Value.ToString().Trim());
                sb.AppendFormat(" where AssessId={0}", row.Cells["AssessId"].Value.ToString().Trim());      //
                result = Common.helper.ExecuteNonQuery(Common.helper.connectionStr, sb.ToString());
                if (result == 0)
                {
                    MessageBox.Show(row.Cells["AssessId"].Value.ToString().Trim() + "提交失败");
                    break;
                }
            }
            if (result > 0)
            {
                MessageBox.Show("提交成功");
                BindAssess();
            }
        } 
        #endregion

        #region 事件：查询
        private void btnShow_Click_1(object sender, EventArgs e)
        {
            if (cmbEpName.SelectedValue == null || (int)cmbEpName.SelectedValue == -1)
            {
                MessageBox.Show("您还没有选择员工");
                return;
            }
            BindAssess();
        } 
        #endregion

        #region 事件：部门索引改变时发生
        private void cmbDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindPos();
        } 
        #endregion

        #region 事件：职位索引改变时发生
        private void cmbPos_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindEpName();
        } 
        #endregion

        #region 根据职位下拉框判断姓名下拉框是否为空
        public void BindEpName()
        {
            if ((int)cmbPos.SelectedValue == -1)         //这里为空，去掉前面的
            {
                cmbEpName.Enabled = false;
                return;
            }
            else
            {
                cmbEpName.Enabled = true;
            }
            StringBuilder sb = new StringBuilder();
            sb.Append("select '员工编号:'+CONVERT(varchar(20), EpId)+'姓名:'+EpName as EpName,EpId from Emploryee where 1=1 ");
            if ((int)cmbDept.SelectedValue != -1 && (int)cmbDept.SelectedValue != 0)
            {
                sb.Append(" and DptId=");
                sb.Append(cmbDept.SelectedValue.ToString().Trim());
            }
            if ((int)cmbPos.SelectedValue != -1 && (int)cmbPos.SelectedValue != 0)
            {
                sb.Append(" and PId=");
                sb.Append(cmbPos.SelectedValue.ToString().Trim());
            }

            ds = Common.helper.ExecuteDataSet(Common.helper.connectionStr, sb.ToString(), "Emplory");
            cmbEpName.DisplayMember = "EpName";
            cmbEpName.ValueMember = "EpId";
            DataRow row = ds.Tables[0].NewRow();
            row[0] = "请选择";
            row[1] = -1;
            ds.Tables[0].Rows.InsertAt(row, 0);
            cmbEpName.DataSource = ds.Tables[0];
            //getFinalScore();
            //getSelfScore();
            //getFinalScore();
        }
        #endregion

        #region 事件：员工姓名索引改变时发生
        private void cmbEpName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEpName.SelectedValue != null && (int)cmbEpName.SelectedValue != -1 && (int)cmbEpName.SelectedValue != 0)
            {
                BindAssess();
            }
        } 
        #endregion

        #region 事件：日期值改变时发生
        private void dptAssessMonth_ValueChanged(object sender, EventArgs e)
        {
            if (dptAssessMonth.Value.Year != DateTime.Now.Year || dptAssessMonth.Value.Month != DateTime.Now.Month)
            {
                GetEnable(false);
            }
            else
            {
                GetEnable(true);
            }
            //if (cmbPos.SelectedValue != null && (int)cmbPos.SelectedValue != -1 && (int)cmbPos.SelectedValue != 0)
            //{
            //BindAssess();
            //}
        } 
        #endregion

    }
}
