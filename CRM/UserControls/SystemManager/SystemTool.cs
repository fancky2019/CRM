using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CRM.UserControls.SystemManager
{
    public partial class SystemTool : XtraUserControl
    {
        public SystemTool()
        {
            InitializeComponent();
        }

        private void SbtnSystemTool_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(AppDomain.CurrentDomain.BaseDirectory);
        }

        private void SbenUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
