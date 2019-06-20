using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM.Dal;
using CRM.Model.EntityModels;
using CRM.Model.EntityModels.CRM;
using CRM.Model.QueryModels;
using CRM.Model.ViewModels;
using WMS.Dal.ProductManager;

namespace CRM.BLL.ProductManager
{
    public class ProductManagerBll
    {
        ProductDal _dal = null;
        public ProductManagerBll()
        {
            _dal = new ProductDal();
        }
        public (int Count, List<ProductVM> ListProductVM) LoadData(ProductQM qm)
        {
            return _dal.LoadData(qm);
        }
        public int Add(Product product)
        {
            return _dal.Add(product);
        }

        public int Update(Product product)
        {
            return _dal.Update(product);
        }

        public int Delete(Product product)
        {
            return _dal.Delete(product);
        }
        public bool Exist(Product product)
        {
            return _dal.Exist(product);
        }

        public List<ProductVM> QueryWithNoPage(ProductQM qm)
        {
            return _dal.QueryWithNoPage(qm);
        }
    }
}
