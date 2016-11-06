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
    public partial class FrmAssessExample : Form
    {
        //MYYYYYYY
        //public FrmAssessExample frmAssExamle;

        public FrmAssessExample()
        {
            InitializeComponent();
        }

        #region 事件：查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            BindAssessExample();
        } 
        #endregion

        #region 方法：加载考核模板至DataGridView
        public void BindAssessExample()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select AssesExampleId,Title,TotalScore,case IsPass when 0 then '正在审核' when 1 then '已通过' end as IsPass from AssesExample");
            if (txtTitle.Text != string.Empty)
            {
                sb.Append(" where Title like '%");
                sb.Append(txtTitle.Text.Trim());
                sb.Append(" %'");
            }
            sb.Append(" order by AssesExampleId DESC");
            sqlHelper helper = new sqlHelper();
            DataSet ds = helper.ExecuteDataSet(helper.connectionStr, sb.ToString(), null);
            dgvAE.AutoGenerateColumns = false;
            dgvAE.DataSource = ds.Tables[0];
        } 
        #endregion

        #region 窗体加载事件
        private void FrmAssessExample_Load(object sender, EventArgs e)
        {
            //this.assesExampleTableAdapter.Fill(this.hrDataSet.AssesExample);
            BindAssessExample();
        } 
        #endregion

        #region 事件：添加
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddAssExampleContent optionAE = new FrmAddAssExampleContent();
            optionAE.frmAssExamle = this;
            optionAE.isAdd = 1;
            optionAE.ShowDialog();
        } 
        #endregion

        #region 事件：删除
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("您是否要删除", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                StringBuilder sb = new StringBuilder();

                foreach (DataGridViewRow row in dgvAE.SelectedRows)
                {
                    if (row.Cells["AssExampleId"].Value != null)
                    {
                        sb.Append(row.Cells["AssExampleId"].Value.ToString());
                        sb.Append(",");
                    }
                }
                if (sb.Length == 0)
                {
                    MessageBox.Show("您没有选择要删除的项");
                }
                else
                {
                    sb.Remove(sb.Length - 1, 1);
                    sb.Insert(0, "delete AssesExample where AssesExampleId in (");
                    sb.Append(")");
                    if (Common.helper.ExecuteNonQuery(Common.helper.connectionStr, sb.ToString()) > 0)
                    {
                        BindAssessExample();
                        MessageBox.Show("删除成功");
                    }
                    else
                    {
                        MessageBox.Show("删除失败");
                    }
                }
            }
        } 
        #endregion

        #region 事件：修改
        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmAddAssExampleContent optionAE = new FrmAddAssExampleContent();
            optionAE.frmAssExamle = this;
            if (dgvAE.SelectedRows.Count == 1)
            {
                if (dgvAE.SelectedRows[0].Cells["AssExampleId"].Value != null)
                {
                    optionAE.AssRow = dgvAE.SelectedRows[0];
                    optionAE.isAdd = 0;
                    optionAE.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("您还没有选择要修改的内容");
                return;
            }
        } 
        #endregion

        #region 事件：管理和设置
        private void btnSet_Click(object sender, EventArgs e)
        {
            FrmAssessDetail frmAssesDetail = new FrmAssessDetail();
            if (dgvAE.SelectedRows.Count == 1)
            {
                frmAssesDetail.MyASERow = dgvAE.SelectedRows[0];
            }
            else
            {
                MessageBox.Show("请选择一行");
                return;
            }
            frmAssesDetail.ShowDialog();
        } 
        #endregion

        #region 事件：审核通过
        private void btnPass_Click(object sender, EventArgs e)
        {
            SetPass(true);
        }
        #endregion

        #region 事件：审核不通过
        private void btnNoPass_Click(object sender, EventArgs e)
        {
            SetPass(false);
        } 
        #endregion

        #region 方法：审核是否通过，
        protected void SetPass(bool IsPass)
        {
            if (dgvAE.SelectedRows.Count != 1)
            {
                MessageBox.Show("请选择一行");
                return;
            }
            StringBuilder PassSb = new StringBuilder();
            PassSb.Append("update AssesExample set IsPass=");
            int InsertLenth = PassSb.Length;
            PassSb.Append("where AssesExampleId=");
            PassSb.Append(dgvAE.SelectedRows[0].Cells["AssExampleId"].Value.ToString().Trim());
            if (IsPass)
            {
                StringBuilder sb = new StringBuilder(" select sum(Score) from ASEDetail where AssessExampleId = ");
                sb.Append(dgvAE.SelectedRows[0].Cells["AssExampleId"].Value.ToString().Trim());
                double currentScore = (double)Common.helper.ExecuteScalar(Common.helper.connectionStr, sb.ToString());
                if(currentScore != (double)dgvAE.SelectedRows[0].Cells["TotalScores"].Value)
                {
                    MessageBox.Show("分数未达到总分，不能通过审核");
                    return;
                }
                else
                {
                    PassSb.Insert(InsertLenth, 1);
                }
            }
            else
            {
                PassSb.Insert(InsertLenth, 0);
            }
            if(Common.helper.ExecuteNonQuery(Common.helper.connectionStr,PassSb.ToString())>0)
            {
                MessageBox.Show("状态修改成功");
            }
            else
            {
                MessageBox.Show("状态修改失败");
            }
            BindAssessExample();
        }
        #endregion

        
    }
}
