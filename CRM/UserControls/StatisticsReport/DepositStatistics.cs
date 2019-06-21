using CRM.BLL.ProductManager;
using CRM.BLL.StatisticsReport;
using CRM.Model.EntityModels;
using CRM.Model.QueryModels;
using CRM.Model.ViewModels;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CRM.UserControls.ProcuctManager
{
    public partial class DepositStatistics : XtraUserControl
    {
        StatisticsReportBll _bll = null;
        public DepositStatistics()
        {
            InitializeComponent();
            _bll = new StatisticsReportBll();
            InitData(this.pageNavigator1.Skip, this.pageNavigator1.Take);
        }




        private void gridViewProduct_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle > -1)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

      
        private void InitData(int skip,int take)
        {
           var result = _bll.DepositStatistics(new DepositQM()
            {
                Skip = skip,
                Take = take
            });
            this.pageNavigator1.Total = result.Count;
            this.gridProduct.DataSource = result.ListDepositVM;
        }

        private void pageNavigator1_PageIndexChanged(int take, int skip)
        {
            InitData(skip,take);
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbtnQuery_Click(object sender, EventArgs e)
        {
            DepositQM qm = new DepositQM();
            qm.Skip = 0;
            qm.Take = this.pageNavigator1.Take;
            qm.PhoneNumber = this.tePhoneNumber.Text.Trim();
            qm.UserName = this.teUserName.Text.Trim();

            var result = _bll.DepositStatistics(qm);
            this.gridProduct.DataSource = null;
            this.pageNavigator1.Total = result.Item1;
            this.gridProduct.DataSource = result.Item2;
        }

        //没有查询到数据时候，显示提示
        private void gridViewProduct_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            if (this.gridViewProduct.RowCount == 0)
            {
                Font f = new Font("宋体", 12, FontStyle.Bold);
                Rectangle r = new Rectangle(gridViewProduct.GridControl.Width / 2 - 100, e.Bounds.Top + 5, e.Bounds.Right - 5, e.Bounds.Height - 5);
                e.Graphics.DrawString("没有查询到数据!", f, Brushes.Red, r);
            }
        }
    }
}
