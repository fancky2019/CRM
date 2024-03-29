﻿using CRM.BLL.CheckOutManager;
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
    public partial class CheckOutManager : XtraUserControl
    {
        ProductManagerBll _productManagerBll = null;
        //   InOutStockManagerBll _inOutStockManagerBll = null;
        List<ProductVM> _selectedProduct = null;

        SystemCodeBll _systemCodeBll = null;
        MemberManagerBll _memberManagerBll = null;
        CheckOutManagerBll _checkOutManagerBll = null;

        MemberAmountVM _memberAmountVM = null;

        List<SystemCode> _checkOutTypeSystemCodeList = null;
        public CheckOutManager()
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
            this.cbeCheckOutType.Properties.Items.AddRange(_checkOutTypeSystemCodeList.Select(p => p.DisplayName).ToList());
            this.cbeCheckOutType.SelectedIndex = 0;
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
            this.sliMemberCanUseInfo.Text = $"可用余额{_memberAmountVM.TotalAmount}元，可用积分{_memberAmountVM.TotalBonusPoints}。";
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
                ProductName = this.teProductName.Text.Trim(),
                Skip = this.pageNavigator.Skip,
                Take = this.pageNavigator.Take
            };
            var result = _productManagerBll.LoadData(qm);
            this.pageNavigator.Total = result.Count;
            this.gridProductSource.DataSource = result.ListProductVM;
            for (int j = 0; j < _selectedProduct.Count; j++)
            {
                for (int i = 0; i < gridViewProductSource.DataRowCount; i++)
                {
                    ProductVM product = this.gridViewProductSource.GetRow(i) as ProductVM;//获取选中行的实体
                    if (product.ID == _selectedProduct[j].ID)
                    {
                        this.gridViewProductSource.SelectRow(i);
                    }
                }
            }
            initDadaComplete = true;
            //this.gridViewProductSource.ClearSelection();//清除选中

        }
        private void sbtnAdd_Click(object sender, EventArgs e)
        {
            int[] rowHandles = this.gridViewProductSource.GetSelectedRows();//获取选中行号；
            if (rowHandles.Length == 0)
            {
                XtraMessageBox.Show($"请选择要操作的产品！", "提示", MessageBoxButtons.OK);
                return;
            }
        }


        private void gridViewProductSource_MouseDown(object sender, MouseEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo hInfo = gridViewProductSource.CalcHitInfo(new Point(e.X, e.Y));
            if (e.Button == MouseButtons.Left && e.Clicks == 2)
            {
                //判断光标是否在行范围内  
                if (hInfo.InRow)
                {
                    this.gridViewProductSource.SelectRow(hInfo.RowHandle);

                    ////取得选定行信息  
                    //ProductVM product = this.gridViewProductSource.GetRow(hInfo.RowHandle) as ProductVM;//获取选中行的实体
                    //if (_selectedProduct.Any(p => p.ProductName == product.ProductName && p.ProductStyle == product.ProductStyle))
                    //{
                    //    return;
                    //}
                    //ProductVM vm = product.CloneModel<ProductVM>();
                    //_selectedProduct.Add(vm);
                    //this.gridProductDetail.DataSource = null;
                    //this.gridProductDetail.DataSource = _selectedProduct;
                }
            }
        }

        private void sbtnSave_Click(object sender, EventArgs e)
        {
            ////int[] rowHandles = this.gridViewProductSource.GetSelectedRows();//获取选中行号；
            if (_selectedProduct.Count == 0)
            {
                XtraMessageBox.Show($"套餐明细里没有产品，请添加套餐！", "提示", MessageBoxButtons.OK);
                return;
            }
            if(string.IsNullOrEmpty(this.cbeCheckOutType.Text.Trim()))
            {
                XtraMessageBox.Show($"请选择支付类型！", "提示", MessageBoxButtons.OK);
                return;
            }

            CheckOutOrderVM checkOutOrderVM = new CheckOutOrderVM
            {
                Type = _checkOutTypeSystemCodeList.First(p => p.DisplayName == this.cbeCheckOutType.Text).CodeValue,
                Products = _selectedProduct,
                CreateTime = DateTime.Now,
                MemberID=this._memberAmountVM.MemberID,
                ModifyTime = DateTime.Now,
                Status=0

            };

            if (checkOutOrderVM.Type == 0)
            {
                var payAmount = checkOutOrderVM.Products.Sum(p => p.RealityPrice);
                if(_memberAmountVM.TotalAmount< payAmount)
                {
                    XtraMessageBox.Show($"余额不足，请充值！", "提示", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                var payBonusPoints = checkOutOrderVM.Products.Sum(p => p.BonusPoints);
                if (_memberAmountVM.TotalBonusPoints < payBonusPoints)
                {
                    XtraMessageBox.Show($"积分不足，请用现金付账！", "提示", MessageBoxButtons.OK);
                    return;
                }
            }
            //InOutStockVM inOutStockVM = this.Tag as InOutStockVM;
            //InOutStock inOutStock = null;
            //int result = 0;
            //if (inOutStockVM == null)//新增
            //{

            //     inOutStock = new InOutStock()
            //    {
            //        GUID = Guid.NewGuid(),
            //        IsComplete = false,
            //        CreateTime = DateTime.Now,
            //        Status = 1,
            //        Type = (short)(this.cmeInOut.SelectedItem.ToString() == "出库" ? 2 : 1)
            //    };
            //    result = _inOutStockManagerBll.AddInOutStockAndDetail(inOutStock, inOutStockDetailList);

            //}
            //else //编辑
            //{
            //    inOutStock = inOutStockVM.MapTo<InOutStockVM, InOutStock>();
            //    inOutStockDetailList.ForEach(p =>
            //    {
            //        p.InOutStockID = inOutStock.ID;
            //    });
            //    result = _inOutStockManagerBll.UpdateInOutStockAndDetail(inOutStock, inOutStockDetailList);   
            //}
            var result = _checkOutManagerBll.CheckOut(checkOutOrderVM, _memberAmountVM);
            if (result > 0)
            {
                XtraMessageBox.Show($"结账成功！", "提示", MessageBoxButtons.OK);
                ClearUI();
            }
            else
            {
                XtraMessageBox.Show($"结账失败！", "提示", MessageBoxButtons.OK);
            }
        }


        private void ClearUI()
        {
            this.tePhoneNumber.Text = "";
            //为" "不能为""，否则会显示默认控件name值
            this.sliMemberCanUseInfo.Text = " ";
            _selectedProduct.Clear();
            this.gridProductSource.DataSource = null;
            this.gridProductDetail.DataSource = null;
        }

        private void repositoryItemTextEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //TextEdit te = sender as TextEdit;
                //int isNumber = -1;
                //if (!int.TryParse(te.Text.Trim(), out isNumber))
                //{
                //    return;
                //}
                //this.gridViewProductSource.SetRowCellValue(gridViewProductSource.FocusedRowHandle, "Count", isNumber);
                this.gridViewProductDetail.CloseEditor();
                gridViewProductDetail.UpdateCurrentRow();
            }
        }

        private void gridViewProductSource_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (!initDadaComplete)
            {
                return;
            }
            //int focusedRowHandle = this.gridViewProductSource.FocusedRowHandle;
            int[] selectedRowHandles = this.gridViewProductSource.GetSelectedRows();//获取选中行号；
            int[] rowHandles = new int[gridViewProductSource.DataRowCount];
            for (int i = 0; i < gridViewProductSource.DataRowCount; i++)
            {
                rowHandles[i] = i;
            }
            int[] unSelectedRowHandles = rowHandles.Except(selectedRowHandles).ToArray();
            for (int i = 0; i < selectedRowHandles.Length; i++)//添加选中的行
            {

                ProductVM product = this.gridViewProductSource.GetRow(selectedRowHandles[i]) as ProductVM;//获取实体
                if (_selectedProduct.Any(p => p.ID == product.ID))
                {
                    continue;
                }
                else
                {
                    ProductVM vm = product.DepthClone<ProductVM>();
                    _selectedProduct.Add(vm);
                }

            }
            for (int i = 0; i < unSelectedRowHandles.Length; i++)//移除没选中的行
            {
                ProductVM product = this.gridViewProductSource.GetRow(unSelectedRowHandles[i]) as ProductVM;//获取实体
                ProductVM exist = _selectedProduct.Where(p => p.ID == product.ID).FirstOrDefault();
                if (exist != null)
                {
                    _selectedProduct.Remove(exist);
                }
            }
            this.gridProductDetail.DataSource = null;
            this.gridProductDetail.DataSource = _selectedProduct;
        }

        #region  单元格编辑验证
        private void gridViewProductDetail_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            //int count = -1;   //获取单元格的值
            //int.TryParse(this.gridViewProductSource.GetRowCellValue(gridViewProductSource.FocusedRowHandle, "Count").ToString(), out count);
            //if(count<=0)
            //{
            //    return;
            //}
            //ProductVM product = this.gridViewProductDetail.GetRow(this.gridViewProductDetail.FocusedRowHandle) as ProductVM;//获取选中行的实体
            //List<ProductVM> list = this.gridProductSource.DataSource as List<ProductVM>;
            //ProductVM sourceProduct = list.Where(p => p.ID == product.ID).FirstOrDefault();
            //if (sourceProduct.Count < product.Count)
            //{
            //    if (this.cmeInOut.SelectedItem.ToString() == "出库")
            //    {
            //        //GridColumn gcCount = gridViewProductDetail.Columns["Count"];//产品数量
            //        gridViewProductDetail.SetColumnError(this.gcCount, "产品数量不能大于当前库存数量！");
            //        this.sbtnSave.Enabled = false;
            //    }
            //}
            //else
            //{
            //    if (this.cmeInOut.SelectedItem.ToString() == "出库")
            //    {
            //        gridViewProductDetail.ClearColumnErrors();
            //        this.sbtnSave.Enabled = true;
            //    }
            //}
        }

        private void gridViewProductDetail_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;//不弹出消息框
        }
        #endregion



        private void ribeDelete_Click(object sender, EventArgs e)
        {
            ProductVM product = this.gridViewProductDetail.GetRow(gridViewProductDetail.FocusedRowHandle) as ProductVM;//获取选中行的实体
            this._selectedProduct.Remove(product);
            int[] rowHandles = this.gridViewProductSource.GetSelectedRows();//获取选中行号；
            for (int i = 0; i < rowHandles.Length; i++)
            {
                ProductVM pro = this.gridViewProductSource.GetRow(rowHandles[i]) as ProductVM;//获取选中行的实体
                if (pro.ID == product.ID)
                {
                    this.gridViewProductSource.UnselectRow(rowHandles[i]);
                    break;
                }
            }

            this.gridProductDetail.DataSource = null;
            this.gridProductDetail.DataSource = _selectedProduct;
        }

        private void GridViewProductSource_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            if (this.gridViewProductSource.RowCount == 0)
            {
                Font f = new Font("宋体", 12, FontStyle.Bold);
                Rectangle r = new Rectangle(gridViewProductSource.GridControl.Width / 2 - 100, e.Bounds.Top + 5, e.Bounds.Right - 5, e.Bounds.Height - 5);
                e.Graphics.DrawString("没有查询到数据!", f, Brushes.Red, r);
            }
        }

        private void GridViewProductSource_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle > -1)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void GridViewProductDetail_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle > -1)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void GridViewProductDetail_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            if (this.gridViewProductDetail.RowCount == 0)
            {
                Font f = new Font("宋体", 12, FontStyle.Bold);
                Rectangle r = new Rectangle(gridViewProductDetail.GridControl.Width / 2 - 100, e.Bounds.Top + 5, e.Bounds.Right - 5, e.Bounds.Height - 5);
                e.Graphics.DrawString("没有查询到数据!", f, Brushes.Red, r);
            }
        }
    }
}
