using CRM.Common;
using CRM.Dal.CheckOutManager;
using CRM.Model.EntityModels;
using CRM.Model.EntityModels.CRM;
using CRM.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.BLL.CheckOutManager
{
    public class CheckOutManagerBll
    {
        MemberAmountDal _memberAmountDal = null;
        CheckOutManagerDal _checkOutManagerDal = null;
        public CheckOutManagerBll()
        {
            _memberAmountDal = new MemberAmountDal();
            _checkOutManagerDal = new CheckOutManagerDal();
        }

        public MemberAmountVM GetMemberAmountByPhoneNumber(string phoneNumber)
        {
            return _memberAmountDal.GetMemberAmountByPhoneNumber(phoneNumber);
        }

        public int CheckOut(CheckOutOrderVM checkOutOrderVM)
        {
            try
            {
                CheckOutOrder checkOutOrder = new CheckOutOrder()
                {
                    MemberID = checkOutOrderVM.MemberID,
                    CreateTime = checkOutOrderVM.CreateTime,
                    ModifyTime = checkOutOrderVM.ModifyTime,
                    Status = checkOutOrderVM.Status,
                    Type = checkOutOrderVM.Type
                };

                List<CheckOutOrderDetail> checkOutOrderDetailList = new List<CheckOutOrderDetail>();//添加的产品
                checkOutOrderVM.Products.ForEach(p =>
                {
                    checkOutOrderDetailList.Add(new CheckOutOrderDetail()
                    {
                        DiscountPrice = p.DiscountPrice,
                        BonusPoints = p.BonusPoints,
                        ProductID = p.ID,
                        CreateTime = DateTime.Now,
                        Discount = p.Discount,
                        RealityPrice = p.RealityPrice
                    });
                });

                return _checkOutManagerDal.CheckOut(checkOutOrder, checkOutOrderDetailList);
                //    return _checkOutManagerDal.CheckOutByTransactionScope(checkOutOrder, checkOutOrderDetailList);
                //  return _checkOutManagerDal.TransactionScopeTest();

            }
            catch (Exception ex)
            {
                Log.Error<CheckOutManagerBll>(ex.ToString());
                return 0;
            }
        }
    }
}
