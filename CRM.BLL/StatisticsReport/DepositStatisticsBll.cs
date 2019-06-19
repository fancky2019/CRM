using CRM.Dal.StatisticsReport;
using CRM.Model.QueryModels;
using CRM.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.BLL.StatisticsReport
{
    public class DepositStatisticsBll
    {
        DepositStatisticsDal _dal = null;
        public DepositStatisticsBll()
        {
            _dal = new DepositStatisticsDal();
        }

        public (int Count, List<DepositVM> ListProductVM) LoadData(DepositQM qm)
        {
            return _dal.LoadData(qm);
        }
    }
}
