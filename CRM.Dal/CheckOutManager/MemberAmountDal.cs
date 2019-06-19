using CRM.Common;
using CRM.Model.EntityModels;
using CRM.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Dal.CheckOutManager
{
    public class MemberAmountDal
    {

        public MemberAmountVM GetMemberAmountByPhoneNumber(string phoneNumber)
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
                                     PhoneNumber = k.PhoneNumber,
                                     TotalAmount = p.TotalAmount,
                                     TotalBonusPoints = p.TotalBonusPoints,
                                     CreateTime = p.CreateTime,
                                     ModifyTime = p.ModifyTime
                                 };
                    if (!string.IsNullOrEmpty(phoneNumber))
                    {
                        result = result.Where(p => p.PhoneNumber== phoneNumber);
                    }
                    return result.FirstOrDefault();

                }
            }
            catch (Exception ex)
            {
                Log.Error<MemberAmountDal>(ex.ToString());
                return null;
            }
        }
    }
}
