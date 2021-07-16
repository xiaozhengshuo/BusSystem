using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Models;
using BusQueryApp;
using DAL;
namespace BusQueryApp
{
    public partial class FrmUserLogon : Form
    {
        public FrmUserLogon()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserLogonManage ulm = new UserLogonManage();
            ulm.GetAllUserLogon();
            if (txtLogonusername.Text.Trim() != UserLogonService.use)
            {
                if (txtLoginpwd.Text.Trim() == txtpwd2.Text.Trim() && txtLoginpwd.Text.Trim() != "")
                {
                    string username = txtLogonusername.Text.Trim();
                    string pwd = txtLoginpwd.Text.Trim();
                    string pwd2 = txtpwd2.Text.Trim();
                    string name = txtname.Text.Trim();
                    string role = "普通用户";
                    string phone = txtphone.Text.Trim();
                    User u = ulm.GetInsterallUser(username, pwd, role, name, phone);
                    MessageBox.Show("注册成功！");
                    this.Close();
                }
                else MessageBox.Show("两次密码输入不同！");
            }
            else MessageBox.Show("用户名重复");
        }
    }
}
