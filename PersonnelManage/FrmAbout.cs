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

    public partial class FrmAbout : Form
    {
        int index = 0;
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (index < imgAbout.Images.Count - 1)
            {
                index++;
            }
            else
            {
                index = 0;
            }
            pbAbout.Image = imgAbout.Images[index];
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (label1.ForeColor == Color.Gray)
            {
                label1.ForeColor = Color.Red;
            }else
            if (label1.ForeColor == Color.Red)
            {
                label1.ForeColor = Color.Blue;
            }else
            {
                label1.ForeColor = Color.Gray;
            }
        }

        private void FrmAbout_Load(object sender, EventArgs e)
        {
            //label1.BackColor = Color.Transparent;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
