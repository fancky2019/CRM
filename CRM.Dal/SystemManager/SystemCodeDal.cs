using CRM.Common;
using CRM.Model.EntityModels;
using CRM.Model.EntityModels.CRM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Dal.SystemManager
{
    public class SystemCodeDal
    {
        public List<SystemCode> GetSystemCode(string codeName)
        {
            try
            {
                using (CRMDbContext dbContext = new Dal.CRMDbContext())
                {
                    var systemCodes = dbContext.SystemCode.AsQueryable();
                    if (string.IsNullOrEmpty(codeName))
                    {
                        systemCodes = systemCodes.Where(p => p.CodeName == codeName);
                    }
                    return systemCodes.ToList();
                }
            }
            catch (Exception ex)
            {
                Log.Error<SystemCodeDal>(ex.ToString());
                return null;
            }

        }
    }
}
