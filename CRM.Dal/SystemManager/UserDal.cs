using CRM.Model.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Dal.SystemManager
{
   public class UserDal
    {
        public User GetUser(string userName)
        {
            using (CRMDbContext dbContext = new Dal.CRMDbContext())
            {
                return dbContext.User.FirstOrDefault<User>(p => p.UserName == userName);
            }
        
        }

    }
}
