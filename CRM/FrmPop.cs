using DevExpress.XtraBars.Ribbon;
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
using CRM.UserControls;

namespace CRM
{
    public partial class FrmPop :XtraForm
    {
        public FrmPop()
        {
            InitializeComponent();
        }

        public static void Show(UserControl sourceControl,string text,EditUserControl child, Action action, int width=710,int height=550)
        {
            Control control = sourceControl.Parent;
            while (true)
            {
                if (!(control is FrmMain))
                {
                    control = control.Parent;
                    continue;
                }
                else
                {
                    break;
                }
            }
            FrmPop frmPop = new CRM.FrmPop();
            frmPop.Width = width;
            frmPop.Height = height;
            frmPop.Text = text;
            frmPop.Owner = (FrmMain)control;
            frmPop.Controls.Add(child);
            child.Dock = DockStyle.Fill;
            frmPop.FormClosed += (sender, e) =>
             {
                 action?.Invoke();
             };
            frmPop.ShowDialog();

        }


    }
}
