using CRM.BLL.CheckOutManager;
using CRM.BLL.ProductManager;
using CRM.BLL.StatisticsReport;
using CRM.BLL.SystemManager;
using CRM.Model.EntityModels.CRM;
using CRM.Model.QueryModels;
using CRM.Model.ViewModels;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WMS.UserControls.InOutStockManager
{
    public partial class CheckOutStatistics : XtraUserControl
    {
        StatisticsReportBll _statisticsReportBll = null;

        public CheckOutStatistics()
        {
            InitializeComponent();
            _statisticsReportBll = new StatisticsReportBll();
        }
        private void CheckOutManager_Load(object sender, EventArgs e)
        {
            QueryData();
        }

        private void sbtnQuery_Click(object sender, EventArgs e)
        {
            this.pageNavigator.Skip = 0;
            QueryData();
        }
        private void pageNavigator1_PageIndexChanged(int take, int skip)
        {
            QueryData();
        }

        private void QueryData()
        {
            CheckOutOrderQM qm = new CheckOutOrderQM()
            {
                UserName = this.teUserName.Text.Trim(),
                PhoneNumber = this.tePhoneNumber.Text.Trim(),
                Skip = this.pageNavigator.Skip,
                Take = this.pageNavigator.Take
            };
            var result = _statisticsReportBll.CheckOutOrderStatistic(qm);
            this.pageNavigator.Total = result.Count;
            this.gcCheckOutOrder.DataSource = result.ListCheckOutOrderVM;
        }


        #region  单选 主从

        //控制单选
        private void gvCheckOutOrder_MouseDown(object sender, MouseEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo hInfo = this.gvCheckOutOrder.CalcHitInfo(new Point(e.X, e.Y));
            if (e.Button == MouseButtons.Left)
            {
                //判断光标是否在行范围内  
                if (hInfo.InRow)
                {
                    //上次选择的行，此次选择的事件还没结束
                    var selectedRowHandles = this.gvCheckOutOrder.GetSelectedRows().ToList();

                    foreach (var i in selectedRowHandles)
                    {
                        //  清空之前选择的
                        if (i != hInfo.RowHandle)
                        {
                            this.gvCheckOutOrder.UnselectRow(i);
                            //     this.gvCheckOutOrder.SelectRow(hInfo.RowHandle);
                        }
                    }
                }
            }

        }


        //控制从表数据
        private void GvCheckOutOrder_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            var selectedRowHandles = this.gvCheckOutOrder.GetSelectedRows().ToList();
            if (selectedRowHandles.Count == 0)
            {
                this.gcCheckOutOrderDetail.DataSource = null;
            }
            else
            {
                //取得焦点行信息  
                CheckOutOrderVM checkOutOrderVM = this.gvCheckOutOrder.GetRow(this.gvCheckOutOrder.FocusedRowHandle) as CheckOutOrderVM;//获取实体
                this.gcCheckOutOrderDetail.DataSource = _statisticsReportBll.GetCheckOutOrderDetail(new CheckOutOrderDetailQM { CheckOutOrderID = checkOutOrderVM.ID });
            }


        }

        #endregion

        private void GvCheckOutOrder_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            if (this.gvCheckOutOrder.RowCount == 0)
            {
                Font f = new Font("宋体", 12, FontStyle.Bold);
                Rectangle r = new Rectangle(gvCheckOutOrder.GridControl.Width / 2 - 100, e.Bounds.Top + 5, e.Bounds.Right - 5, e.Bounds.Height - 5);
                e.Graphics.DrawString("没有查询到数据!", f, Brushes.Red, r);
            }
        }

        private void GvCheckOutOrder_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle > -1)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void GvCheckOutOrderDetail_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            if (this.gvCheckOutOrderDetail.RowCount == 0)
            {
                Font f = new Font("宋体", 12, FontStyle.Bold);
                Rectangle r = new Rectangle(gvCheckOutOrderDetail.GridControl.Width / 2 - 100, e.Bounds.Top + 5, e.Bounds.Right - 5, e.Bounds.Height - 5);
                e.Graphics.DrawString("没有查询到数据!", f, Brushes.Red, r);
            }
        }

        private void GvCheckOutOrderDetail_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle > -1)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
    }
}
