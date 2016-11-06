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
    public partial class FrmAssessDetail : Form
    {
        public DataGridViewRow MyASERow;

        public FrmAssessDetail()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            BindAssesDetail();
        }
        /// <summary>
        /// 查询所有信息
        /// </summary>
        public void BindAssesDetail()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select ASDetailId, ASDContent,Score from ASEDetail where AssessExampleId=");
            sb.Append(MyASERow.Cells["AssExampleId"].Value.ToString());
            if (txtContent.Text.Trim() != string.Empty)
            {
                sb.Append(" and ASDContent like '%");
                sb.Append(txtContent.Text.Trim());
                sb.Append("%'");
            }
            DataSet ds = Common.helper.ExecuteDataSet(Common.helper.connectionStr, sb.ToString(), "ASEDetail");
            //DataSet ds = Common.sqlHelper.ExcuteDataSet(Common.sqlHelper.connectionStr, sb.ToString(), null);
            dgvAEDetail.AutoGenerateColumns = false;
            dgvAEDetail.DataSource = ds.Tables[0];
            GetCurrentScore();   //这里调用   
        }

        /// <summary>
        /// 得到当前总分，这里有问题
        /// </summary>
        protected void GetCurrentScore()
        {
            double sum = 0;
            lblCurrentScore.Text = string.Empty;
            foreach (DataGridViewRow row in dgvAEDetail.Rows)
            {
                sum += (double)row.Cells["Score"].Value;
            }
            lblCurrentScore.Text = "总分：";
            lblCurrentScore.Text += sum.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmASEDetailOption aseOption = new frmASEDetailOption();
            aseOption.IsAdd = 1;
            aseOption.frmASEDetail = this;
            aseOption.AssesExampleId = (int)MyASERow.Cells["AssExampleId"].Value;
            aseOption.ShowDialog();
        }
        //删除
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您是否真的要删除", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                StringBuilder sb = new StringBuilder();
                foreach (DataGridViewRow rows in dgvAEDetail.SelectedRows)
                {
                    if (rows.Cells["ASDetailId"].Value != null)
                    {
                        sb.Append(rows.Cells["ASDetailId"].Value.ToString().Trim());
                        sb.Append(",");
                    }
                }
                if (sb.Length == 0)
                {
                    MessageBox.Show("您还没有选择要删除的内容");
                }
                else
                {
                    sb.Remove(sb.Length - 1, 1);
                    sb.Insert(0, "delete ASEDetail where ASDetailId in(");
                    sb.Append(")");
                    if (Common.helper.ExecuteNonQuery(Common.helper.connectionStr, sb.ToString()) > 0)
                    {
                        MessageBox.Show("删除成功");
                        BindAssesDetail();
                    }
                    else
                    {
                        MessageBox.Show("删除失败");
                    }
                }
            }
        }

        //判断是否超过总分
        public bool IsMoreTotalScore(double score)
        {
            bool isMore = false;
            double sum = 0;
            foreach (DataGridViewRow row in dgvAEDetail.Rows)
            {
                sum += (double)row.Cells["Score"].Value;        //把每个单项总分加起来
            }
            sum += score;
            if (sum > (double)MyASERow.Cells["TotalScores"].Value)     //判断是否超过满分
            {
                isMore = true;
            }
            return isMore;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmASEDetailOption aseOption = new frmASEDetailOption();
            aseOption.IsAdd = 0;
            aseOption.frmASEDetail = this;
            if (dgvAEDetail.SelectedRows.Count == 1)
            {
                aseOption.AseDetailRow = dgvAEDetail.SelectedRows[0];
                aseOption.ShowDialog();
            }
            else
            {
                MessageBox.Show("请选择一行");
            }
        }

        #region 窗体加载事件
        private void FrmAssessDetail_Load(object sender, EventArgs e)
        {
            lblTitle.Text = MyASERow.Cells["Title"].Value.ToString();
            double sum = 0;
            foreach (DataGridViewRow row in dgvAEDetail.Rows)
            {
                sum += (double)row.Cells["Score"].Value;        //把每个单项总分加起来
            }

            // lblTotalScore.Text ="总分： "+sum;   //总分
            BindAssesDetail();
        } 
        #endregion
    }
}
