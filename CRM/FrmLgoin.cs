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
        public FrmLgoin()
        {
            InitializeComponent();
        }

        private void SbtnLogin_Click(object sender, EventArgs e)
        {
            if(this.ceRememberPassword.Checked)
            {

            }
            this.Hide();
            FrmMain frmMain = new FrmMain();
            frmMain.ShowDialog();
        }
    }
}
