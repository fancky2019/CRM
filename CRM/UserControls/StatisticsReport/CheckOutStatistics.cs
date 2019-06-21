using CRM.BLL.CheckOutManager;
using CRM.BLL.ProductManager;
using CRM.BLL.SystemManager;
using CRM.Common;
using CRM.Model.EntityModels;
using CRM.Model.EntityModels.CRM;
using CRM.Model.QueryModels;
using CRM.Model.ViewModels;
using CRM.UserControls;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WMS.UserControls.InOutStockManager
{
    public partial class CheckOutStatistics : XtraUserControl
    {
        ProductManagerBll _productManagerBll = null;
        //   InOutStockManagerBll _inOutStockManagerBll = null;
        List<ProductVM> _selectedProduct = null;

        SystemCodeBll _systemCodeBll = null;
        MemberManagerBll _memberManagerBll = null;
        CheckOutManagerBll _checkOutManagerBll = null;

        MemberAmountVM _memberAmountVM = null;

        List<SystemCode> _checkOutTypeSystemCodeList = null;
        public CheckOutStatistics()
        {
            InitializeComponent();
            _systemCodeBll = new SystemCodeBll();
            _productManagerBll = new ProductManagerBll();

            // _inOutStockManagerBll = new InOutStockManagerBll();
            _selectedProduct = new List<ProductVM>();


            _checkOutManagerBll = new CheckOutManagerBll();
            _memberManagerBll = new MemberManagerBll();

        }
        private void CheckOutManager_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            _checkOutTypeSystemCodeList = _systemCodeBll.GetSystemCode("CheckOutType");
        
            //  lueCheckOutType.Properties.PopulateColumns();
            //InOutStockVM inOutStockVM = this.Tag as InOutStockVM;
            //if (inOutStockVM != null)
            //{
            //    this.cmeInOut.SelectedIndex = inOutStockVM.Type - 1;
            //    _selectedProduct = _inOutStockManagerBll.GetInOutStockDetail(inOutStockVM.ID);
            //    this.gridProductDetail.DataSource = _selectedProduct;
            //}
        }


        private void sbtnQuery_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tePhoneNumber.Text.Trim()))
            {
                XtraMessageBox.Show($"请先填写会员手机号！", "提示", MessageBoxButtons.OK);
                return;
            }
            else
            {
                Member member = _memberManagerBll.GetMemberByPhoneNumber(this.tePhoneNumber.Text.Trim());
                if (member == null)
                {
                    XtraMessageBox.Show($"不存在手机号为{this.tePhoneNumber.Text.Trim()}的会员！", "提示", MessageBoxButtons.OK);
                    return;
                }
            }

            if (_memberAmountVM == null)
            {
                _memberAmountVM = _checkOutManagerBll.GetMemberAmountByPhoneNumber(this.tePhoneNumber.Text.Trim());
                if (_memberAmountVM == null)
                {
                    XtraMessageBox.Show($"您的余额为零请充值！", "提示", MessageBoxButtons.OK);
                    return;
                }
            }
       
            this.pageNavigator.Skip = 0;
            InitData();
        }
        private void pageNavigator1_PageIndexChanged(int take, int skip)
        {
            InitData();
        }
        bool initDadaComplete = false;
        private void InitData()
        {
            initDadaComplete = false;
            ProductQM qm = new ProductQM()
            {
                ProductName = this.teUserName.Text.Trim(),
                Skip = this.pageNavigator.Skip,
                Take = this.pageNavigator.Take
            };
            var result = _productManagerBll.LoadData(qm);
            this.pageNavigator.Total = result.Count;
            this.gridCheckOutOrder.DataSource = result.ListProductVM;
            for (int j = 0; j < _selectedProduct.Count; j++)
            {
                for (int i = 0; i < gridViewCheckOutOrder.DataRowCount; i++)
                {
                    ProductVM product = this.gridViewCheckOutOrder.GetRow(i) as ProductVM;//获取选中行的实体
                    if (product.ID == _selectedProduct[j].ID)
                    {
                        this.gridViewCheckOutOrder.SelectRow(i);
                    }
                }
            }
            initDadaComplete = true;
            //this.gridViewProductSource.ClearSelection();//清除选中

        }



        private void gridViewProductSource_MouseDown(object sender, MouseEventArgs e)
        {
            //DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo hInfo = gridViewCheckOutOrder.CalcHitInfo(new Point(e.X, e.Y));
            //if (e.Button == MouseButtons.Left && e.Clicks == 2)
            //{
            //    //判断光标是否在行范围内  
            //    if (hInfo.InRow)
            //    {
            //        this.gridViewCheckOutOrder.SelectRow(hInfo.RowHandle);

            //        ////取得选定行信息  
            //        //ProductVM product = this.gridViewProductSource.GetRow(hInfo.RowHandle) as ProductVM;//获取选中行的实体
            //        //if (_selectedProduct.Any(p => p.ProductName == product.ProductName && p.ProductStyle == product.ProductStyle))
            //        //{
            //        //    return;
            //        //}
            //        //ProductVM vm = product.CloneModel<ProductVM>();
            //        //_selectedProduct.Add(vm);
            //        //this.gridProductDetail.DataSource = null;
            //        //this.gridProductDetail.DataSource = _selectedProduct;
            //    }
            //}

            DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo hInfo = this.gridViewCheckOutOrder.CalcHitInfo(new Point(e.X, e.Y));
            if (e.Button == MouseButtons.Left && e.Clicks == 2)
            {
                //判断光标是否在行范围内  
                if (hInfo.InRow)
                {
                    int[] selectedRowHandles = this.gridViewCheckOutOrder.GetSelectedRows();
                    foreach (var i in selectedRowHandles)
                    {
                        this.gridViewCheckOutOrder.UnselectRow(i);
                    }
                    this.gridViewCheckOutOrder.SelectRow(hInfo.RowHandle);
                    List<CheckOutOrderVM> list = this.gridViewCheckOutOrder.DataSource as List<CheckOutOrderVM>;

                    ////取得选定行信息  
                    CheckOutOrderVM order = this.gridViewCheckOutOrder.GetRow(hInfo.RowHandle) as CheckOutOrderVM;//获取实体
                  //  this.gridCheckOutOrderDetail.DataSource = _bll.GetInOutStockDetail(order.ID);
                }
            }

        }




    }
}
