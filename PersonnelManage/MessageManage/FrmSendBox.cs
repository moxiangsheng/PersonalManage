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
    public partial class FrmSendBox : Form
    {
        public String EpIds;
        public String EpNames;
        public FrmReceiveMessage frmes;

        public FrmSendBox()
        {
            InitializeComponent();
        }

        #region 窗体加载事件：加载发送人
        private void FrmSendBox_Load(object sender, EventArgs e)
        {
            txtAccepter.Text = EpNames;
        } 
        #endregion

        #region 发送事件
        private void btnSend_Click(object sender, EventArgs e)
        {
            sqlHelper helper = new sqlHelper();
            string[] Ids = EpIds.Split(',');
            StringBuilder faulsSend = new StringBuilder();
            foreach (string Id in Ids)
            {
                int res = 0;
                StringBuilder sSql = new StringBuilder();
                sSql.Append("Insert into Message (MessageContent,SendEmploryId,AceptEmploryId,IsRead)");
                sSql.AppendFormat(" values ('{0}'", txtContent.Text.Trim());
                sSql.AppendFormat(",{0},{1},0)", Common.EpId, Id);
                res = helper.ExecuteNonQuery(helper.connectionStr, sSql.ToString());
                if (res < 1)
                {
                    faulsSend.Append(Id);
                    faulsSend.Append(",");
                }

            }
            if (faulsSend.Length == 0)
            {
                MessageBox.Show("         全 部 发 送 成 功 ！", "提示");
                //new FrmReceiveMessage().BindAcceptMessage();
                this.Close();
            }
            else
            {
                faulsSend.Remove(faulsSend.Length - 1, 1);
                MessageBox.Show("以下员工发送失败：" + faulsSend);
            }
        } 
        #endregion

        #region 取消
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
        #endregion
    }
}
