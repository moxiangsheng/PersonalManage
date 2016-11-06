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
    public partial class FrmShowMessage : Form
    {
        public DataGridViewRow currentRow;
        public FrmReceiveMessage frmmessage;

        public FrmShowMessage()
        {
            InitializeComponent();
        }

        #region 窗体加载事件
        private void FrmShowMessage_Load(object sender, EventArgs e)
        {
            lblSendDept.Text = currentRow.Cells["DeptName"].Value.ToString();
            lblSendPosition.Text = currentRow.Cells["positionName"].Value.ToString();
            lblSender.Text = currentRow.Cells["EpName"].Value.ToString();
            lblSendTime.Text = currentRow.Cells["SendTime"].Value.ToString();
            txtContent.Text = currentRow.Cells["MessageContent"].Value.ToString();
            
            
        } 
        #endregion

        #region 事件：窗体关闭后发生更新接收消息窗体的是否已读状态，然后刷新加载信息
        private void FrmShowMessage_FormClosed(object sender, FormClosedEventArgs e)
        {
            string sSql = "update Message set IsRead =1 where MessageId=" + currentRow.Cells["MessageId"].Value.ToString().Trim();
            sqlHelper helper = new sqlHelper();
            helper.ExecuteNonQuery(helper.connectionStr, sSql);//更新状态
            frmmessage.BindAcceptMessage();//加载刷新
        } 
        #endregion
    }
}
