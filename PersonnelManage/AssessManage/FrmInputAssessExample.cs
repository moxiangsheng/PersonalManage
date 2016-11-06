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
    public partial class FrmInputAssessExample : Form
    {
        public int EmploryId;
        public FrmAssessManage asses;
        public string AssesTime;

        public FrmInputAssessExample()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            BindAssessExample();
        }

        /// <summary>
        /// 查询模板，从别的类里面复制过来
        /// </summary>
        public void BindAssessExample()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select AssesExampleId,Title,TotalScore from AssesExample where IsPass=1");
            if (txtTitle.Text != string.Empty)
            {
                sb.Append(" and Title like '%");
                sb.Append(txtTitle.Text.Trim());
                sb.Append("%'");
            }
            sb.Append(" order by AssesExampleId DESC");
            DataSet ds = Common.helper.ExecuteDataSet(Common.helper.connectionStr, sb.ToString(), null);
            dgvAE.AutoGenerateColumns = false;
            dgvAE.DataSource = ds.Tables[0];
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            if (dgvAE.SelectedRows.Count != 1)
            {
                MessageBox.Show("请选择一行");
                return;
            }
            StringBuilder sb = new StringBuilder();
            sb.Append("insert into Assess ([EmploerId], [AssesContent],[Score],[SelfScore],[LeaderScore],[AssessMonth])");
            sb.Append(" select ");
            sb.Append(EmploryId);
            sb.Append(" ,ASDContent");
            sb.Append(" ,Score");
            sb.Append(" ,0");
            sb.Append(" ,0,'");
            sb.Append(AssesTime);
            sb.Append("' from ASEDetail where AssessExampleId=");
            sb.Append(dgvAE.SelectedRows[0].Cells["AssExampleId"].Value.ToString());

            if (Common.helper.ExecuteNonQuery(Common.helper.connectionStr, sb.ToString()) > 0)
            {
                MessageBox.Show("导入成功");
                asses.BindAssess();
                this.Close();
            }
            else
            {
                MessageBox.Show("导入失败");
            }
        }

        private void FrmInputAssessExample_Load(object sender, EventArgs e)
        {
            BindAssessExample();
        }
    }
}
