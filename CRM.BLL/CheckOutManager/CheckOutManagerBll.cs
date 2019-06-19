using CRM.Dal.CheckOutManager;
using CRM.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.BLL.CheckOutManager
{
  public  class CheckOutManagerBll
    {
        MemberAmountDal _dal = null;
        public CheckOutManagerBll()
        {
            _dal = new MemberAmountDal();
        }

        public MemberAmountVM GetMemberAmountByPhoneNumber(string phoneNumber)
        {
            return _dal.GetMemberAmountByPhoneNumber(phoneNumber);
        }
    }
}
