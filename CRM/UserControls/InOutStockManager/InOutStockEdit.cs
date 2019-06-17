using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRM.BLL.SystemManager;
using CRM.Model.QueryModels;
using CRM.Model.ViewModels;
using DevExpress.XtraEditors;
using CRM.Common;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using CRM.Model.EntityModels;
using CRM.BLL.ProductManager;
using CRM.BLL.InOutStockManager;

namespace CRM.UserControls.InOutStockManager
{
    public partial class InOutStockEdit : EditUserControl
    {
        ProductManagerBll _productManagerBll = null;
        InOutStockManagerBll _inOutStockManagerBll = null;
        List<ProductVM> _selectedProduct = null;
        public InOutStockEdit()
        {
            InitializeComponent();
            _productManagerBll = new ProductManagerBll();
            _inOutStockManagerBll = new InOutStockManagerBll();
            _selectedProduct = new List<ProductVM>();
        }

        private void sbtnQuery_Click(object sender, EventArgs e)
        {
            InitData(0, this.pageNavigator1.Take);
        }
        private void pageNavigator1_PageIndexChanged(int take, int skip)
        {
            InitData(skip, take);
        }

        private void InitData(int skip, int take)
        {
            ProductQM qm = new ProductQM()
            {
                ProductName = this.teProductName.Text.Trim(),
                Skip = skip,
                Take = take
            };
            Tuple<int, List<ProductVM>> result = _productManagerBll.LoadData(qm);
            this.pageNavigator1.Total = result.Item1;
            this.gridProductSource.DataSource = result.Item2;
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
            int[] rowHandles = this.gridViewProductSource.GetSelectedRows();//获取选中行号；
            if (rowHandles.Length == 0)
            {
                XtraMessageBox.Show($"产品明细里没有产品，请添加产品！", "提示", MessageBoxButtons.OK);
                return;
            }
            //AddSelectedProduct();

            InOutStock inOutStock = new InOutStock()
            {
                GUID = Guid.NewGuid(),
                IsComplete = false,
                CreateTime = DateTime.Now,
                Status = 1,
                Type = (short)(this.cmeInOut.SelectedItem.ToString() == "出库" ? 2 : 1)
            };
            List<InOutStockDetail> inOutStockDetailList = new List<InOutStockDetail>();
            _selectedProduct.ForEach(p =>
            {
                inOutStockDetailList.Add(new InOutStockDetail()
                {
                    GUID = Guid.NewGuid(),
                    CrateTime = DateTime.Now,
                    Count = p.Count,
                    ModifyTime = DateTime.Now,
                    ProductID = p.ID,
                    Status = 1
                });
            });
            int result = _inOutStockManagerBll.AddInOutStockAndDetail(inOutStock, inOutStockDetailList);
            if (result > 0)
            {
                XtraMessageBox.Show($"保存成功！", "提示", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                XtraMessageBox.Show($"保存失败！", "提示", MessageBoxButtons.OK);
            }
        }
        private void AddSelectedProduct()
        {
            int[] rowHandles = this.gridViewProductSource.GetSelectedRows();//获取选中行号；
            _selectedProduct.Clear();
            for (int i = 0; i < rowHandles.Length; i++)
            {
                //取得选定行信息  
                ProductVM product = this.gridViewProductSource.GetRow(rowHandles[i]) as ProductVM;//获取选中行的实体
                if (_selectedProduct.Any(p => p.ProductName == product.ProductName && p.ProductStyle == product.ProductStyle))
                {
                    return;
                }
                ProductVM vm = product.CloneModel<ProductVM>();
                _selectedProduct.Add(vm);
                this.gridProductDetail.DataSource = null;
                this.gridProductDetail.DataSource = _selectedProduct;
            }
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
            int[] rowHandles = this.gridViewProductSource.GetSelectedRows();//获取选中行号；
            if (rowHandles.Length == 0)
            {
                _selectedProduct.Clear();
                this.gridProductDetail.DataSource = null;
                this.gridProductDetail.DataSource = _selectedProduct;
            }
            else
            {
                AddSelectedProduct();
            }
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
            ProductVM product = this.gridViewProductDetail.GetRow(this.gridViewProductDetail.FocusedRowHandle) as ProductVM;//获取选中行的实体
            List<ProductVM> list = this.gridProductSource.DataSource as List<ProductVM>;
            ProductVM sourceProduct = list.Where(p => p.ID == product.ID).FirstOrDefault();
            if (sourceProduct.Count < product.Count)
            {
                if (this.cmeInOut.SelectedItem.ToString() == "出库")
                {
                    //GridColumn gcCount = gridViewProductDetail.Columns["Count"];//产品数量
                    gridViewProductDetail.SetColumnError(this.gcCount, "产品数量不能大于当前库存数量！");
                    this.sbtnSave.Enabled = false;
                }
            }
            else
            {
                if (this.cmeInOut.SelectedItem.ToString() == "出库")
                {
                    gridViewProductDetail.ClearColumnErrors();
                    this.sbtnSave.Enabled = true;
                }
            }
        }

        private void gridViewProductDetail_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;//不弹出消息框
        }
        #endregion

        private void cmeInOut_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cmeInOut.SelectedItem != null)
            {
                this.sbtnQuery.Enabled = true;
            }
        }

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
    }
}
