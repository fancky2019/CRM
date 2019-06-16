using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM.Common;
using CRM.Model.EntityModels;

namespace CRM.Dal
{
   public class InOutStockDal
    {
        public List<InOutStock> LoadData()
        {
            try
            {
                using (WMSDbContext dbContext = new Dal.WMSDbContext())
                {
                    return dbContext.InOutStock.ToList();
                }
            }
            catch (Exception ex)
            {
                Log.Error<InOutStockDal>(ex.ToString());
                return null;
            }
        }
        public int AddInOutStockAndDetail(InOutStock inOutStock,List<InOutStockDetail> inOutStockDetailList)
        {
            try
            {
                using (WMSDbContext dbContext = new Dal.WMSDbContext())
                {
                    dbContext.InOutStock.Add(inOutStock);
                    dbContext.SaveChanges();
                    inOutStockDetailList.ForEach(p =>
                    {
                        p.InOutStockID = inOutStock.ID;
                    });
                    dbContext.InOutStockDetail.AddRange(inOutStockDetailList);
                    dbContext.SaveChanges();
                    return 1;
                }
            }
            catch (Exception ex)
            {
                Log.Error<InOutStockDal>(ex.ToString());
                return 0;
            }
        }
    }
}
