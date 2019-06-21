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
    public class StatisticsReportDal
    {
        public (int Count, List<DepositVM> ListDepositVM) DepositStatistics(DepositQM qm)
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
                                     UserName = k.UserName,
                                     PhoneNumber = k.PhoneNumber,
                                     DepositAmount = p.DepositAmount,
                                     PayAmount = p.PayAmount,
                                     CreateTime = p.CreateTime,
                                     Remark = p.Remark
                                 };
                    if (!string.IsNullOrEmpty(qm.PhoneNumber))
                    {
                        result = result.Where(p => p.PhoneNumber.Contains(qm.PhoneNumber));
                    }
                    if (!string.IsNullOrEmpty(qm.UserName))
                    {
                        result = result.Where(p => p.UserName.Contains(qm.UserName));
                    }

                    var count = result.Count();
                    var list = result.OrderBy(p => p.CreateTime).Skip(qm.Skip).Take(qm.Take).ToList();
                    return (count, list);
                }
            }
            catch (Exception ex)
            {
                Log.Error<StatisticsReportDal>(ex.ToString());
                return (0, null);
            }
        }


        public (int Count, List<MemberAmountVM> ListMemberAmountVM) MemberAmountStatistic(MemberAmountQM qm)
        {
            try
            {
                using (CRMDbContext dbContext = new CRMDbContext())
                {
                    var result = from p in dbContext.MemberAmount
                                 join k in dbContext.Member on p.MemberID equals k.ID
                                 select new MemberAmountVM
                                 {
                                     ID = p.ID,
                                     MemberID = p.MemberID,
                                     UserName = k.UserName,
                                     PhoneNumber = k.PhoneNumber,
                                     TotalAmount = p.TotalBonusPoints,
                                     TotalBonusPoints = p.TotalBonusPoints,
                                     CreateTime = p.CreateTime,
                                     ModifyTime = p.ModifyTime
                                 };
                    if (!string.IsNullOrEmpty(qm.PhoneNumber))
                    {
                        result = result.Where(p => p.PhoneNumber.Contains(qm.PhoneNumber));
                    }
                    if (!string.IsNullOrEmpty(qm.UserName))
                    {
                        result = result.Where(p => p.UserName.Contains(qm.UserName));
                    }

                    var count = result.Count();
                    var list = result.OrderBy(p => p.CreateTime).Skip(qm.Skip).Take(qm.Take).ToList();
                    return (count, list);
                }
            }
            catch (Exception ex)
            {
                Log.Error<StatisticsReportDal>(ex.ToString());
                return (0, null);
            }
        }

    }
}
