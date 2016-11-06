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
    public partial class FrmSingleAssess : Form
    {
        public int EmploryId;
        public FrmAssessManage asses;
        public string AssesTime;

        public FrmSingleAssess()
        {
            InitializeComponent();
        }

        #region 事件：保存
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtContent.Text.Trim() == string.Empty)
            {
                MessageBox.Show("考核内容不能为空");
                return;
            }
            else if (txtScore.Text.Trim() == string.Empty)
            {
                MessageBox.Show("分数不能为空");
                return;
            }

            StringBuilder sb = new StringBuilder();
            sb.Append("insert into Assess ([EmploerId], [AssesContent],[Score],[SelfScore],[LeaderScore],[AssessMonth])");
            sb.Append(" values(");
            sb.Append(EmploryId);
            sb.Append(" ,'");
            sb.Append(txtContent.Text.Trim());
            sb.Append(" ','");
            sb.Append(txtScore.Text.Trim());
            sb.Append(" ',0");
            sb.Append(" ,0,'");
            sb.Append(AssesTime);
            sb.Append(" ')");

            if (Common.helper.ExecuteNonQuery(Common.helper.connectionStr, sb.ToString()) > 0)
            {
                MessageBox.Show("添加成功");
                asses.BindAssess();
                this.Close();
            }
            else
            {
                MessageBox.Show("添加失败");
            }
        } 
        #endregion

        private void btnCencel_Click(object sender, EventArgs e)
        {

        }

        private void FrmSingleAssess_Load(object sender, EventArgs e)
        {

        }
    }
}
