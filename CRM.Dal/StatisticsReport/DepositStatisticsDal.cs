using CRM.Common;
using CRM.Model.QueryModels;
using CRM.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMS.Dal.ProductManager;

namespace CRM.Dal.StatisticsReport
{
    public class DepositStatisticsDal
    {
        public (int Count, List<DepositVM> ListProductVM) LoadData(DepositQM qm)
        {
            try
            {
                using (CRMDbContext dbContext = new CRMDbContext())
                {
                    var result = from p in dbContext.Deposit
                                 join k in dbContext.Member on p.MemberID equals k.ID
                                 select new DepositVM
                                 {
                                     ID = p.ID, 
                                     MemberID = p.MemberID,
                                     PhoneNumber=k.PhoneNumber,
                                     DepositAmount = p.DepositAmount,
                                     PayAmount=p.PayAmount,
                                     CreateTime=p.CreateTime,
                                     Remark=p.Remark
                                 };
                    if (!string.IsNullOrEmpty(qm.PhoneNumber))
                    {
                        result = result.Where(p => p.PhoneNumber.Contains(qm.PhoneNumber));
                    }

                    var count = result.Count();
                    var list = result.OrderBy(p => p.CreateTime).Skip(qm.Skip).Take(qm.Take).ToList();
                    return (count, list);
                }
            }
            catch (Exception ex)
            {
                Log.Error<DepositStatisticsDal>(ex.ToString());
                return (0, null);
            }
        }
    }
}
