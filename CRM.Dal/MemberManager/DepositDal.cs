using CRM.Common;
using CRM.Model.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Dal.MemberManager
{
    public class DepositDal
    {
        public int Add(Deposit deposit)
        {
            try
            {
                //EF6默认回创建事务
                using (CRMDbContext dbContext = new CRMDbContext())
                {
           
                    MemberAmount memberAmount = dbContext.MemberAmount.Where(p => p.MemberID == deposit.MemberID).FirstOrDefault();
                    if(memberAmount==null)
                    {
                        memberAmount = new MemberAmount
                        {
                            MemberID = deposit.MemberID,
                            TotalAmount = deposit.DepositAmount,
                            CreateTime = DateTime.Now,
                            ModifyTime=DateTime.Now
                        };
                        dbContext.MemberAmount.Add(memberAmount);
                    }
                    else
                    {
                        memberAmount.TotalAmount += deposit.DepositAmount;
                        memberAmount.ModifyTime = DateTime.Now;
                    }
                    dbContext.Deposit.Add(deposit);
                    dbContext.SaveChanges();
                    return 1;
                }
            }
            catch (Exception ex)
            {
                Log.Error<DepositDal>(ex.ToString());
                return 0;
            }
        }
    }
}
