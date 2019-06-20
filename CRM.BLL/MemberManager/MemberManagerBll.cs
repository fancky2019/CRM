using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM.Dal;
using CRM.Dal.MemberManager;
using CRM.Model.EntityModels;
using CRM.Model.EntityModels.CRM;
using CRM.Model.QueryModels;
using CRM.Model.ViewModels;


namespace CRM.BLL.ProductManager
{
    public class MemberManagerBll
    {
        MemberDal _memberDal = null;
        DepositDal _depositDal = null;
        public MemberManagerBll()
        {
            _memberDal = new MemberDal();
            _depositDal = new DepositDal();
        }
        public (int Count, List<MemberVM> ListProductVM) LoadData(MemberQM qm)
        {
            return _memberDal.LoadData(qm);
        }
        public int Add(Member member)
        {
            return _memberDal.Add(member);
        }

        public int Update(Member member)
        {
            return _memberDal.Update(member);
        }

        public int Delete(Member member)
        {
            return _memberDal.Delete(member);
        }
        public bool Exist(Member member)
        {
            return _memberDal.Exist(member);
        }

        public List<MemberVM> QueryWithNoPage(MemberQM qm)
        {
            return _memberDal.QueryWithNoPage(qm);
        }

        public Member GetMemberByPhoneNumber(string phoneNumber)
        {
            return _memberDal.GetMemberByPhoneNumber(phoneNumber);
        }
        public int  MemberDeposit(Deposit deposit)
        {
            return _depositDal.Add(deposit);
        }

    }
}
