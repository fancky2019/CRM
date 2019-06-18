using CRM.BLL.ProductManager;
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
    public partial class ProductManager : UserControl
    {
        ProductManagerBll _bll = null;
        public ProductManager()
        {
            InitializeComponent();
            _bll = new ProductManagerBll();
            InitData(this.pageNavigator1.Skip, this.pageNavigator1.Take);
        }

        private void gridViewProduct_MouseUp(object sender, MouseEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo hi = this.gridViewProduct.CalcHitInfo(e.Location);
            if (hi.InRow && e.Button == MouseButtons.Right)
            {
                popupMenu1.ShowPopup(MousePosition);
            }
        }

        private void sbtAdd_Click(object sender, EventArgs e)
        {
            ProductEdit productEdit = new ProcuctManager.ProductEdit();
            FrmPop.Show(this, "新增产品", productEdit, (() =>
             {
                 InitData(this.pageNavigator1.Skip, this.pageNavigator1.Take);
             }), productEdit.Width + 80, productEdit.Height + 100);

        }

        private void gridViewProduct_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle > -1)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        //双击编辑行
        private void gridViewProduct_MouseDown(object sender, MouseEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo hInfo = gridViewProduct.CalcHitInfo(new Point(e.X, e.Y));
            if (e.Button == MouseButtons.Left && e.Clicks == 2)
            {
                //判断光标是否在行范围内  
                if (hInfo.InRow)
                {
                    //取得选定行信息  
                    ProductVM product = this.gridViewProduct.GetRow(hInfo.RowHandle) as ProductVM;//获取选中行的实体
                    ProductEdit productEdit = new ProcuctManager.ProductEdit();
                    productEdit.Tag = product;
                    FrmPop.Show(this, "编辑产品", productEdit, (() =>
                    {
                        InitData(this.pageNavigator1.Skip, this.pageNavigator1.Take);
                    }), productEdit.Width + 80, productEdit.Height + 100);
                }
            }
        }

        private void barButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (e.Item.Tag.ToString())
            {
                case "update":
                    Edit();
                    break;
                case "delete":
                    Delete();
                    break;
            }
        }

        private void Edit()
        {
            ProductEdit productEdit = new ProcuctManager.ProductEdit();
            Product product = this.gridViewProduct.GetRow(this.gridViewProduct.FocusedRowHandle) as Product;
            productEdit.Tag = product;
            FrmPop.Show(this, "编辑产品", productEdit, (() =>
            {
                InitData(this.pageNavigator1.Skip, this.pageNavigator1.Take);
            }), productEdit.Width + 80, productEdit.Height + 100);
        }

        private void Delete()
        {
            if (DialogResult.OK == XtraMessageBox.Show($"您确定要删除员该产品信息吗？", "警告", MessageBoxButtons.OKCancel))
            {
                ProductEdit productEdit = new ProcuctManager.ProductEdit();
                Product product = this.gridViewProduct.GetRow(this.gridViewProduct.FocusedRowHandle) as Product;
                //if (_bll.Delete(product) > 0)
                //{
                //    XtraMessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK);
                //    InitData(this.pageNavigator1.Skip,this.pageNavigator1.Take);
                //}
            }
        }

        private void InitData(int skip,int take)
        {
            //Tuple<int, List<ProductVM>> result = _bll.LoadData(new ProductQM()
            //{
            //    Skip = skip,
            //    Take = take
            //});
            //this.pageNavigator1.Total = result.Item1;
            //this.gridProduct.DataSource = result.Item2;
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
            ProductQM qm = new ProductQM();
            qm.Skip = 0;
            qm.Take = this.pageNavigator1.Take;
            qm.ProductName = this.teProductName.Text.Trim();
       
            //Tuple<int, List<ProductVM>> result = _bll.LoadData(qm);
            //this.gridProduct.DataSource = null;
            //this.pageNavigator1.Total = result.Item1;
            //this.gridProduct.DataSource = result.Item2;
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
