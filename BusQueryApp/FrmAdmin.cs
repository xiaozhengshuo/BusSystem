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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        #region 加载数据库数据
        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            BusManage busbll = new BusManage();
            gvBus.DataSource = busbll.GetAllMembers();
            colid.DataPropertyName = "number";
            colline.DataPropertyName = "line";

        }
        #endregion

        # region 添加按钮
        private void button1_Click(object sender, EventArgs e)
        {
            BusService.addid = int.Parse(txtNumb.Text.Trim());
            BusService.addro = txtRoute.Text.Trim();
            BusManage busbll = new BusManage();
            busbll.AddBus();
            gvBus.DataSource = busbll.GetAllMembers();
            txtNumb.Text = "";
            txtDeletNumb.Text = "";
            txtRoute.Text = "";
         }
        #endregion
        #region 返回按钮
        private void btnAdminQuit_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMain frm = new FrmMain();
            frm.Show();
        }
        #endregion
        #region 删除按钮
        private void button2_Click(object sender, EventArgs e)
        {
            BusService.deletId = int.Parse(txtDeletNumb.Text.Trim());
            BusManage busManage = new BusManage();
            busManage.DeletBus();
            gvBus.DataSource = busManage.GetAllMembers();
            txtNumb.Text = "";
            txtDeletNumb.Text = "";
            txtRoute.Text = "";
        }
        #endregion
    }
}
