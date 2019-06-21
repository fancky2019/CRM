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
    public class StatisticsReportBll
    {
        StatisticsReportDal _dal = null;
        public StatisticsReportBll()
        {
            _dal = new StatisticsReportDal();
        }
        public (int Count, List<DepositVM> ListDepositVM) DepositStatistics(DepositQM qm)
        {
            return _dal.DepositStatistics(qm);
        }

        public (int Count, List<MemberAmountVM> ListMemberAmountVM) MemberAmountStatistic(MemberAmountQM qm)
        {
            return _dal.MemberAmountStatistic(qm);
        }

        public (int Count, List<CheckOutOrderVM> ListCheckOutOrderVM) CheckOutOrderStatistic(CheckOutOrderQM qm)
        {

            return _dal.CheckOutOrderStatistic(qm);

        }


        public List<CheckOutOrderDetailVM> GetCheckOutOrderDetail(CheckOutOrderDetailQM qm)
        {
            return _dal.GetCheckOutOrderDetail(qm);
        }
    }
}
