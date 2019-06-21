using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM.UserControls
{
    public partial class Developing : EditUserControl
    {
        public Developing()
        {
            InitializeComponent();
        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(AppDomain.CurrentDomain.BaseDirectory);
        }
    }
}
