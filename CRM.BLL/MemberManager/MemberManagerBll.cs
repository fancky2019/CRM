using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM.Dal;
using CRM.Model.EntityModels;
using CRM.Model.QueryModels;
using CRM.Model.ViewModels;
using WMS.Dal.ProductManager;

namespace CRM.BLL.ProductManager
{
    public class MemberManagerBll
    {
        MemberDal _dal = null;
        public MemberManagerBll()
        {
            _dal = new MemberDal();
        }
        public (int Count, List<MemberVM> ListProductVM) LoadData(MemberQM qm)
        {
            return _dal.LoadData(qm);
        }
        public int Add(Member member)
        {
            return _dal.Add(member);
        }

        public int Update(Member member)
        {
            return _dal.Update(member);
        }

        public int Delete(Member member)
        {
            return _dal.Delete(member);
        }
        public bool Exist(Member member)
        {
            return _dal.Exist(member);
        }

        public List<MemberVM> QueryWithNoPage(MemberQM qm)
        {
            return _dal.QueryWithNoPage(qm);
        }
    }
}
