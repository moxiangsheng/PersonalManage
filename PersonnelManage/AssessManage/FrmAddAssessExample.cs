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
    public partial class FrmAddAssExampleContent : Form
    {
        public FrmAssessExample frmAssExamle;
        public int isAdd = 1;       //1表示添加，0表示修改
        public DataGridViewRow AssRow;

        public FrmAddAssExampleContent()
        {
            InitializeComponent();
        }

        private void FrmAddAssessExample_Load(object sender, EventArgs e)
        {
            if (isAdd == 1)
            {
                this.Text = "添加模板";
            }
            else
            {
                this.Text = "修改模板";
                txtTitle.Text = AssRow.Cells["Title"].Value.ToString().Trim();
                txtTotal.Text = AssRow.Cells["TotalScores"].Value.ToString().Trim();
                btnAdd.Text = "修改";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtTitle.Text.Trim() == string.Empty)
            {
                MessageBox.Show("标题栏不能为空");
            }
            else if (txtTotal.Text.Trim() == string.Empty)
            {
                MessageBox.Show("总分不能为空");
            }
            else
            {
                if (isAdd == 1)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendFormat(" INSERT INTO [AssesExample]");
                    sb.AppendFormat(" (");
                    sb.AppendFormat(" [Title],");
                    sb.AppendFormat(" [TotalScore]");
                    sb.AppendFormat(" )");
                    sb.AppendFormat(" VALUES");
                    sb.AppendFormat(" (");
                    sb.AppendFormat(" '{0}',", txtTitle.Text.Trim());
                    sb.AppendFormat(" {0}", txtTotal.Text.Trim());
                    sb.AppendFormat(" )");

                    if (Common.helper.ExecuteNonQuery(Common.helper.connectionStr, sb.ToString()) > 0)
                    {
                        MessageBox.Show("添加成功");
                        frmAssExamle.BindAssessExample();
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
                    sb.Append(" update  [AssesExample]");
                    sb.Append(" set Title='");
                    sb.Append(txtTitle.Text.Trim());
                    sb.Append("',");
                    sb.Append(" TotalScore=");
                    sb.Append(txtTotal.Text.Trim());
                    sb.Append(" where AssesExampleId=");
                    sb.Append(AssRow.Cells["AssExampleId"].Value.ToString());

                    if (Common.helper.ExecuteNonQuery(Common.helper.connectionStr, sb.ToString()) > 0)
                    {
                        MessageBox.Show("修改成功");
                        frmAssExamle.BindAssessExample();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("修改失败");
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTitle.Text = txtTotal.Text = string.Empty;
        }
    }
}
