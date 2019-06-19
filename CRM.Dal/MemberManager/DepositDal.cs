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
                using (CRMDbContext dbContext = new CRMDbContext())
                {
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
