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
    public partial class MmberManager : UserControl
    {
        MemberManagerBll _bll = null;
        public MmberManager()
        {
            InitializeComponent();
            _bll = new MemberManagerBll();
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
            MemberEdit memberEdit = new ProcuctManager.MemberEdit();
            FrmPop.Show(this, "新增会员", memberEdit, (() =>
             {
                 InitData(this.pageNavigator1.Skip, this.pageNavigator1.Take);
             }));

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
                    MemberVM memberVM = this.gridViewProduct.GetRow(hInfo.RowHandle) as MemberVM;//获取选中行的实体
                    MemberEdit memberEdit = new ProcuctManager.MemberEdit();
                    memberEdit.Tag = memberVM;
                    FrmPop.Show(this, "编辑会员", memberEdit, (() =>
                    {
                        InitData(this.pageNavigator1.Skip, this.pageNavigator1.Take);
                    }));
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
            MemberEdit memberEdit = new ProcuctManager.MemberEdit();
            MemberVM memberVM = this.gridViewProduct.GetRow(this.gridViewProduct.FocusedRowHandle) as MemberVM;
            memberEdit.Tag = memberVM;
            FrmPop.Show(this, "编辑会员", memberEdit, (() =>
            {
                InitData(this.pageNavigator1.Skip, this.pageNavigator1.Take);
            }));
        }

        private void Delete()
        {
            if (DialogResult.OK == XtraMessageBox.Show($"您确定要删除该会员信息吗？", "警告", MessageBoxButtons.OKCancel))
            {
                MemberVM memberVM = this.gridViewProduct.GetRow(this.gridViewProduct.FocusedRowHandle) as MemberVM;
                if (_bll.Delete(new Member { ID= memberVM .ID}) > 0)
                {
                    XtraMessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK);
                    InitData(this.pageNavigator1.Skip, this.pageNavigator1.Take);
                }
            }
        }

        private void InitData(int skip,int take)
        {
           var result = _bll.LoadData(new MemberQM()
            {
                Skip = skip,
                Take = take
            });
            this.pageNavigator1.Total = result.Count;
            this.gridProduct.DataSource = result.ListProductVM;
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
            MemberQM qm = new MemberQM();
            qm.Skip = 0;
            qm.Take = this.pageNavigator1.Take;
            qm.UserName = this.teUserName.Text.Trim();
            qm.PhoneNumber = this.tePhoneNumber.Text.Trim();
            qm.IDCard = this.teIDCard.Text.Trim();

            var result = _bll.LoadData(qm);
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
