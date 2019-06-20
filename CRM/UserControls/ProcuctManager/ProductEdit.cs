using CRM.BLL.ProductManager;
using CRM.Model.EntityModels;
using CRM.Model.EntityModels.CRM;
using CRM.Model.ViewModels;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace CRM.UserControls.ProcuctManager
{
    public partial class ProductEdit : EditUserControl
    {
        ProductManagerBll _productBll = null;
        //((0.)|([1-9]\d*\.?))\d+
        public ProductEdit()
        {
            InitializeComponent();

            _productBll = new ProductManagerBll();


        }
        private void ProductEdit_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                ProductVM product = this.Tag as ProductVM;
                this.teProcuctName.Text = product.ProductName;
                this.seDiscount.Text = product.Discount.ToString();
                this.tePrice.Text = product.Price.ToString();
                this.teBonusPoints.Text = product.BonusPoints.ToString();
                this.meDescription.Text = product.Description;
            }
        }
        private void sbtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(teProcuctName.Text.Trim()))
            {
                XtraMessageBox.Show("套餐名称不能为空！", "提示", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrEmpty(tePrice.Text.Trim()))
            {
                XtraMessageBox.Show("套餐价格不能为空！", "提示", MessageBoxButtons.OK);
                return;
            }
            Product product = new Product()
            {
                ProductName = this.teProcuctName.Text.Trim(),
                Price = decimal.Parse(this.tePrice.Text.Trim()),
                Discount = (short)this.seDiscount.Value,
                BonusPoints = decimal.Parse(this.teBonusPoints.Text),
                GUID = Guid.NewGuid(),
                CreateTime = DateTime.Now,
                ModifyTime = DateTime.Now,
                Description = this.meDescription.Text.Trim(),
                Status = 1
            };
            int result = 0;
            if (this.Tag != null)//编辑
            {
                var oldProduct = this.Tag as ProductVM;
                product.GUID = oldProduct.GUID;
                product.ID = oldProduct.ID;
                product.CreateTime = oldProduct.CreateTime;
                product.ModifyTime = DateTime.Now;
                result = _productBll.Update(product);
            }
            else//新增
            {
                if (_productBll.Exist(product))
                {
                    XtraMessageBox.Show("已存在同名称的该套餐！", "提示", MessageBoxButtons.OK);
                    return;
                }
                result = _productBll.Add(product);
            }
            if (result > 0)
            {
                XtraMessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("保存失败！", "提示", MessageBoxButtons.OK);
            }
        }
    }
}
