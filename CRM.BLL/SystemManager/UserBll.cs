using CRM.Dal.SystemManager;
using CRM.Model.EntityModels;
using CRM.Model.EntityModels.CRM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.BLL.SystemManager
{
    public class UserBll
    {
        UserDal _dal = null;
        public UserBll()
        {
            _dal = new UserDal();
        }

        public User GetUser(string userName)
        {
            return _dal.GetUser(userName);
        }
    }
}
