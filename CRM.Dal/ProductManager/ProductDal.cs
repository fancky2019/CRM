using CRM.Common;
using CRM.Dal;
using CRM.Model.EntityModels;
using CRM.Model.EntityModels.CRM;
using CRM.Model.QueryModels;
using CRM.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WMS.Dal.ProductManager
{
    public class ProductDal
    {
        public  (int Count, List<ProductVM> ListProductVM) LoadData(ProductQM qm)
        {
            try
            {
                using (CRMDbContext dbContext = new CRMDbContext())
                {
                    var result = from p in dbContext.Product                  
                                 select new ProductVM
                                 {
                                     ID = p.ID,
                                     GUID = p.GUID,
                                     ProductName = p.ProductName,
                                     Price = p.Price,
                                     Discount=p.Discount,
                                     BonusPoints=p.BonusPoints,
                                     CreateTime = p.CreateTime,
                                     ModifyTime = p.ModifyTime,
                                     Status = p.Status,
                                     Description =p.Description
                                   
                                 };
                    if (!string.IsNullOrEmpty(qm.ProductName))
                    {
                        result = result.Where(p => p.ProductName.Contains(qm.ProductName));
                    }
                   
                    var count = result.Count();
                    var list = result.OrderBy(p => p.CreateTime).Skip(qm.Skip).Take(qm.Take).ToList();
                    return (count, list);
                }
            }
            catch (Exception ex)
            {
                Log.Error<ProductDal>(ex.ToString());
                return (0,null);
            }
        }
        public int Add(Product product)
        {
            try
            {
                using (CRMDbContext dbContext = new CRMDbContext())
                {
                    dbContext.Product.Add(product);
                    dbContext.SaveChanges();
                    return 1;
                }
            }
            catch (Exception ex)
            {
                Log.Error<ProductDal>(ex.ToString());
                return 0;
            }
        }

        public int Update(Product product)
        {
            try
            {
                using (CRMDbContext dbContext = new CRMDbContext())
                {
                    Product pro = dbContext.Product.Where(p => p.ID == product.ID).FirstOrDefault();
                    pro.ProductName = product.ProductName;        
                    pro.Price = product.Price;
                    pro.Discount = product.Discount;
                    pro.BonusPoints = product.BonusPoints;
                    pro.Description = product.Description;
                    pro.ModifyTime = DateTime.Now;
                    dbContext.SaveChanges();
                    return 1;
                }
            }
            catch (Exception ex)
            {
                Log.Error<ProductDal>(ex.ToString());
                return 0;
            }
        }

        public int Delete(Product product)
        {
            try
            {
                using (CRMDbContext dbContext = new CRMDbContext())
                {
                    Product pro = dbContext.Product.Where(p => p.ID == product.ID).FirstOrDefault();
                    dbContext.Product.Remove(pro);
                    dbContext.SaveChanges();
                    return 1;
                }
            }
            catch (Exception ex)
            {
                Log.Error<ProductDal>(ex.ToString());
                return 0;
            }
        }

        public bool Exist(Product product)
        {
            try
            {
                using (CRMDbContext dbContext = new CRMDbContext())
                {
                    return dbContext.Product.Any(p => p.ProductName == product.ProductName );
                }
            }
            catch (Exception ex)
            {
                Log.Error<ProductDal>(ex.ToString());
                return true;
            }
        }

        public List<ProductVM> QueryWithNoPage(ProductQM qm)
        {
            try
            {
                using (CRMDbContext dbContext = new CRMDbContext())
                {
                    var result = from p in dbContext.Product
                                 select new ProductVM
                                 {
                                     ID = p.ID,
                                     GUID = p.GUID,
                                     ProductName = p.ProductName,
                                     Price = p.Price,
                                     CreateTime = p.CreateTime,
                                     ModifyTime = p.ModifyTime,
                                     Status = p.Status,
                                     Description = p.Description

                                 };
                    if (!string.IsNullOrEmpty(qm.ProductName))
                    {
                        result = result.Where(p => p.ProductName.Contains(qm.ProductName));
                    }
                    return result.ToList();
                }
            }
            catch (Exception ex)
            {
                Log.Error<ProductDal>(ex.ToString());
                return null;
            }
        }
    }
}
