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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            cmbRole.Text = "普通用户";
        }
        #region 登陆按钮
        public static string role;
        public static string name;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserManage userbll = new UserManage();
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()) || string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                MessageBox.Show("用户名或密码不能为空", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string username = txtUserName.Text.Trim();
                string password = txtPassword.Text.Trim();
                User user = userbll.GetMemberByNameAndPwd(username, password);
                if (user != null && user.Role.Trim() == cmbRole.SelectedItem.ToString().Trim())
                {
                    MessageBox.Show("登陆成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    role = user.Role;
                    name = user.Username;
                    username = user.Username;
                    FrmMain frmmain = new FrmMain();
                    frmmain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误，请重新登陆！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUserName.Text = "";
                    txtPassword.Text = "";
                    txtUserName.Focus();
                }
            }
        }
        #endregion
        #region 重置按钮
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }
        #endregion
        #region 用户注册标签
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmUserLogon ful = new FrmUserLogon();
            ful.Show();
        }
        #endregion
        #region 忘记密码标签
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("暂未开放！");
        }
        #endregion
    }
}
