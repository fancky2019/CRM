using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM.UserControls.InOutStockManager
{
    public partial class InOutStockManager : UserControl
    {
        public InOutStockManager()
        {
            InitializeComponent();
        }

        private void sbtAdd_Click(object sender, EventArgs e)
        {
            InOutStockEdit inOutStockEdit = new InOutStockEdit();
            FrmPop.Show(this, "新增出入库", inOutStockEdit, (() =>
            {
                InitData(this.pageNavigator1.Skip, this.pageNavigator1.Take);
            }), inOutStockEdit.Width + 80, inOutStockEdit.Height + 100);

        }

        private void InitData(int skip, int take)
        {
            //Tuple<int, List<ProductVM>> result = _bll.LoadData(new ProductQM()
            //{
            //    Skip = skip,
            //    Take = take
            //});
            //this.pageNavigator1.Total = result.Item1;
            //this.gridProduct.DataSource = result.Item2;
        }
    }
}
