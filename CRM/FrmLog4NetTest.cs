using CRM.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class FrmLog4NetTest : Form
    {
        public FrmLog4NetTest()
        {
            InitializeComponent();
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            var threaID = Thread.CurrentThread.ManagedThreadId;
            Log.Info<FrmLog4NetTest>("info");
            Log.Debug<FrmLog4NetTest>("debug");
            Log.Warn<FrmLog4NetTest>("Warn");
        }

        private void BtnDebug_Click(object sender, EventArgs e)
        {
            Log.Error<FrmLog4NetTest>("error");
            Log.Fatal<FrmLog4NetTest>("Fatal");
        }
    }
}
