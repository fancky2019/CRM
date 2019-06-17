using CRM.BLL.SystemManager;
using CRM.Model.EntityModels;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class FrmLgoin : XtraForm
    {
        UserBll _userBll = null;
        public FrmLgoin()
        {
            InitializeComponent();
            _userBll = new UserBll();
        }

        private void SbtnLogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty( this.teUserName.Text.Trim()))
            {
                this.lblMessage.Text = "账号不能为空！";
                return;
            }
            if (string.IsNullOrEmpty(this.tePassword.Text.Trim()))
            {
                this.lblMessage.Text = "密码不能为空！";
                return;
            }

            User user = _userBll.GetUser(this.teUserName.Text.Trim());
            if(user==null)
            {
                this.lblMessage.Text = "账号不存在！";
                return;
            }
            if(user.Password!=this.tePassword.Text.Trim())
            {
                this.lblMessage.Text = "密码错误！";
                return;
            }
            if (this.ceRememberPassword.Checked)
            {

            }
            this.Hide();
            FrmMain frmMain = new FrmMain();
            frmMain.ShowDialog();
        }
    }
}
