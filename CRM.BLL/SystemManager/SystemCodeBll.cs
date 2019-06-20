using CRM.Dal.SystemManager;
using CRM.Model.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.BLL.SystemManager
{
    public class SystemCodeBll
    {

        SystemCodeDal _systemCodeDal = null;
        public SystemCodeBll()
        {
            _systemCodeDal = new SystemCodeDal();
        }

        public List<SystemCode> GetSystemCode(string codeName)
        {
            return _systemCodeDal.GetSystemCode(codeName);
        }
    }
}
