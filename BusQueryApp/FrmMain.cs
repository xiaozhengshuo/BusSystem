using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusQueryApp;
using Models;
using BLL;

namespace BusQueryApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
                InitializeComponent();
                this.tolUserName.Text = FrmLogin.name;
                this.tolRole.Text = FrmLogin.role;
            if (FrmLogin.role.Trim() == "普通用户")
            {
                this.公交路线管理ToolStripMenuItem.Enabled = false;
                this.btnGuanli.Enabled = false;
                this.toolUserAdmin.Enabled = false;
            }
        }   

        private void btnGuanli_Click(object sender, EventArgs e)
        {
            if (FrmLogin.role.Trim() == "管理员")
            {
                FrmAdmin frmadmin = new FrmAdmin();
                frmadmin.Show();
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tolTime.Text = "系统当前时间：" + System.DateTime.Now.ToString("yyyy-mm-dd  hh:mm:ss");
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您真的要退出系统吗？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void 公交路线管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmLogin.role.Trim() == "管理员")
            {
                FrmAdmin frma = new FrmAdmin();
                frma.Show();
                this.Close();
            }
        }

        private void btnClos_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您真的要退出系统吗？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnChaxun_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmUser frmu = new FrmUser();
            frmu.Show();
        }

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmUserAdmin fua = new FrmUserAdmin();
            fua.Show();
        }

        private void 公交路线查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmUser frmUser = new FrmUser();
            frmUser.Show();
        }

        private void 注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否注销？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.Show();
            }
        }
    }
}
