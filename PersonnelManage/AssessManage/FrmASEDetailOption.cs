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
    public partial class frmASEDetailOption : Form
    {
        public int IsAdd = 1;       //1表示添加，0表示修改
        public int AssesExampleId;
        public FrmAssessDetail frmASEDetail;
        public DataGridViewRow AseDetailRow;
        public frmASEDetailOption()
        {
            InitializeComponent();
        }

        

        private void btnCencel_Click(object sender, EventArgs e)
        {

        }

        private void frmASEDetailOption_Load(object sender, EventArgs e)
        {
            if (IsAdd == 1)
            {
                this.Text = "添加考核项";
            }
            else
            {
                this.Text = "修改考核项";
                txtContent.Text = AseDetailRow.Cells["ASDContent"].Value.ToString().Trim();
                txtScore.Text = AseDetailRow.Cells["Score"].Value.ToString().Trim();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (frmASEDetail.IsMoreTotalScore(double.Parse(txtScore.Text.Trim())))
            {
                MessageBox.Show("已经超过最高分,请重新设置");
                txtScore.Text = string.Empty;
                return;
            }
            if (IsAdd == 1)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(" INSERT INTO [ASEDetail]");
                sb.Append(" ([AssessExampleId]");
                sb.Append(" ,[ASDContent]");
                sb.Append(" ,[Score])");
                sb.Append(" values (");
                sb.Append(AssesExampleId);
                sb.Append(",'");
                sb.Append(txtContent.Text.Trim());
                sb.Append("',");
                sb.Append(txtScore.Text.Trim());
                sb.Append(")");

                if (Common.helper.ExecuteNonQuery(Common.helper.connectionStr, sb.ToString()) > 0)
                {
                    MessageBox.Show("添加成功");
                    frmASEDetail.BindAssesDetail();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(" update [ASEDetail]");
                sb.Append(" set ASDContent='");
                sb.Append(txtContent.Text.Trim());
                sb.Append(" ',Score=");
                sb.Append(txtScore.Text.Trim());
                sb.Append(" where ASDetailId=");
                //sb.Append(AseDetailRow.Cells["ASDetailId"].Value.ToString().Trim());
                sb.Append(AseDetailRow.Cells["ASDetailId"].Value.ToString().Trim());

                if (Common.helper.ExecuteNonQuery(Common.helper.connectionStr, sb.ToString()) > 0)
                {
                    MessageBox.Show("修改成功");
                    frmASEDetail.BindAssesDetail();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
            }
        }

       
    }
}
