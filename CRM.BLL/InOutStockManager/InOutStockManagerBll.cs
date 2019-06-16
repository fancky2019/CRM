using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM.Common;
using CRM.Dal;
using CRM.Model.EntityModels;

namespace CRM.BLL.InOutStockManager
{
    public class InOutStockManagerBll
    {
        InOutStockDal _dal = null;
        public InOutStockManagerBll()
        {
            _dal = new InOutStockDal();
        }
        public int AddInOutStockAndDetail(InOutStock inOutStock, List<InOutStockDetail> inOutStockDetailList)
        {
            return _dal.AddInOutStockAndDetail(inOutStock, inOutStockDetailList);
        }

    }
}
