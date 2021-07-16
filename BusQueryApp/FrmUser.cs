using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using BLL;
namespace BusQueryApp
{
    public partial class FrmUser : Form
    {
        #region 初始化窗体
        public FrmUser()
        {
            InitializeComponent();
        }

        private void txtQnumber_Click(object sender, EventArgs e)
        {
            txtLine01.Enabled = false;
            txtLine02.Enabled = false;
        }

        private void txtLine01_Click(object sender, EventArgs e)
        {
            txtQnumber.Enabled = false;
        }
        private void txtLine02_Click(object sender, EventArgs e)
        {
            txtQnumber.Enabled = false;
        }


        private void btnfanhui_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMain frm =new FrmMain();
            frm.Show();
        }

        private void benQuit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您真的要退出系统吗？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion
        #region 查询按钮
        private void btnQ_Click(object sender, EventArgs e)
        {
            BusQueryManage bqm = new BusQueryManage();
            if (txtQnumber.Text != "")
            {
                int number = int.Parse(txtQnumber.Text.Trim());
                BusMember bmer = bqm.Getnumber(number);
                if (bmer != null)
                    txtQjieguo.Text = bmer.Line;
                else
                    MessageBox.Show("暂无该车辆!");
            }
            else if (txtLine01.Text != "")
            {
                string line01 = txtLine01.Text.Trim();
                string line02 = txtLine02.Text.Trim();
                BusMember bmer = bqm.Getline(line01,line02);
                if(bmer!=null)
                txtQjieguo.Text ="请乘坐"+ bmer.Number.ToString()+"路车!";
                else MessageBox.Show("暂无该车辆!");
            }
            else
            {
                MessageBox.Show("输入有误!");
            }
            #region 查询后重置
            txtLine01.Text = null;
            txtLine02.Text = null;
            txtQnumber.Text = null;
            txtLine01.Enabled = true;
            txtLine02.Enabled = true;
            txtQnumber.Enabled = true;
            #endregion
        }
        #endregion

 

 


    }
}
