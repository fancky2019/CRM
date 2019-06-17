using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRM.Model;
using CRM.Model.EntityModels;

namespace CRM.UserControls
{
    public partial class SkuQuery : UserControl
    {
        List<Sku> _skuList;
        public SkuQuery()
        {
            InitializeComponent();
            _skuList = new List<Sku>();
            Random random = new Random();
            for (int i = 1; i <= 130; i++)
            {
                //_skuList.Add(new Sku()
                //{
                //    ID = i,
                //    SkuName = "SkuName" + i.ToString(),
                //    SkuModel = "SkuName" + i.ToString(),
                //    BarCode = "SkuName" + i.ToString(),
                //    DepotName = (i / 10).ToString(),
                //    Count = random.Next(0, 1000000),
                //    Price = random.Next(0, 1000000)
                //});
            }
            this.pageNavigator1.Total = _skuList.Count;
            this.gridControl1.DataSource = _skuList.Skip(this.pageNavigator1.Skip).Take(this.pageNavigator1.Take).ToList();
        }

        private void pageNavigator1_PageIndexChanged(int take, int skip)
        {
            this.pageNavigator1.Total = _skuList.Count;
            this.gridControl1.DataSource = _skuList.Skip(skip).Take(take).ToList();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var list = _skuList;
            //if (!string.IsNullOrEmpty(this.teSkuName.Text.Trim()))
            //{
            //    list= list.Where(p => p.SkuName.Contains(this.teSkuName.Text.Trim())).ToList();
            //}
            //if (!string.IsNullOrEmpty(this.teSkuModel.Text.Trim()))
            //{
            //    list.Where(p => p.SkuName.Contains(this.teSkuModel.Text.Trim())).ToList();
            //}
            //if (!string.IsNullOrEmpty(this.teBarCode.Text.Trim()))
            //{
            //    list.Where(p => p.SkuName.Contains(this.teBarCode.Text.Trim())).ToList();
            //}
            this.pageNavigator1.Total = list.Count;
            this.gridControl1.DataSource = list.Skip(this.pageNavigator1.Skip).Take(this.pageNavigator1.Take).ToList();
        }
    }
}
