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
    public partial class FrmUserAdmin : Form
    {
        public FrmUserAdmin()
        {
            InitializeComponent();
        }
        #region 加载用户管理窗体
        private void FrmUserAdmin_Load(object sender, EventArgs e)
        {
            UserLogonManage ulm = new UserLogonManage();
            dagvall.DataSource = ulm.GetAllUserLogon();
            colUsername.DataPropertyName = "username";
            colpwd.DataPropertyName = "pwd";
            colRore.DataPropertyName = "role";
            colId.DataPropertyName = "id";
            colname.DataPropertyName = "name";
            colphone.DataPropertyName = "phone";
        }
        #endregion

        #region 删除按钮
        private void btnClou_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtClousUser.Text.Trim());
            UserLogonManage ulm = new UserLogonManage();
            ulm.GetDeletUser(id);
            dagvall.DataSource = ulm.GetAllUserLogon();
            colUsername.DataPropertyName = "username";
            colpwd.DataPropertyName = "pwd";
            colRore.DataPropertyName = "role";
            colId.DataPropertyName = "id";
            colname.DataPropertyName = "name";
            colphone.DataPropertyName = "phone";
        }
        #endregion
        #region 返回按钮
        private void btnfanhui_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMain frmm = new FrmMain();
            frmm.Show();
        }
        #endregion
    }
}
