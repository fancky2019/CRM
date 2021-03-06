﻿using CRM.Common;
using CRM.Model.EntityModels;
using CRM.Model.EntityModels.CRM;
using CRM.Model.EntityModels.WMS;
using CRM.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using WMS.Dal;

namespace CRM.Dal.CheckOutManager
{
    public class CheckOutManagerDal
    {

        public int CheckOut(CheckOutOrder checkOutOrder, List<CheckOutOrderDetail> checkOutOrderDetailList, MemberAmountVM memberAmountVM)
        {
            try
            {

                using (CRMDbContext dbContext = new CRMDbContext())
                {
                    using (var dbContextTransaction = dbContext.Database.BeginTransaction())
                    {
                        try
                        {
                            dbContext.CheckOutOrder.Add(checkOutOrder);
                            dbContext.SaveChanges();

                            checkOutOrderDetailList.ForEach(p =>
                            {
                                p.CheckOutOrderID = checkOutOrder.ID;
                            });
                            dbContext.CheckOutOrderDetail.AddRange(checkOutOrderDetailList);

                            MemberAmount memberAmount =dbContext.MemberAmount.First(p => p.MemberID == checkOutOrder.MemberID);
                            memberAmount.TotalAmount = memberAmountVM.TotalAmount;
                            memberAmount.TotalBonusPoints = memberAmountVM.TotalBonusPoints;
                            memberAmount.ModifyTime = DateTime.Now;

                            dbContext.SaveChanges();
                            dbContextTransaction.Commit();
                            return 1;
                        }
                        catch (Exception ex)
                        {
                            dbContextTransaction.Rollback();
                            Log.Error<CheckOutManagerDal>(ex.ToString());
                            return 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error<CheckOutManagerDal>(ex.ToString());
                return 0;
            }
        }

        public int CheckOutByTransactionScope(CheckOutOrder checkOutOrder, List<CheckOutOrderDetail> checkOutOrderDetailList)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    using (CRMDbContext dbContext = new CRMDbContext())
                    {

                        try
                        {
                            dbContext.CheckOutOrder.Add(checkOutOrder);
                            dbContext.SaveChanges();
                            //throw new Exception("ExceptionTest");
                            checkOutOrderDetailList.ForEach(p =>
                            {
                                p.CheckOutOrderID = checkOutOrder.ID;
                            });
                            dbContext.CheckOutOrderDetail.AddRange(checkOutOrderDetailList);
                            dbContext.SaveChanges();
                            scope.Complete();
                            return 1;
                        }
                        catch (Exception ex)
                        {
                            Log.Error<CheckOutManagerDal>(ex.ToString());
                            return 0;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error<CheckOutManagerDal>(ex.ToString());
                return 0;
            }
        }

        
        public int TransactionScopeTest()
        {
            try
            {
                //垮裤事务：TransactionScope事务,引用程序集：System.Transactions;不支持分布式。
                //服务器 'DELL-PC' 上的 MSDTC 不可用: 在windows控制面版-->管理工具-->服务-->Distributed Transaction Coordinator-->属性-->启动


                //分布式事务：RedLock
                using (TransactionScope scope = new TransactionScope())
                {
                    using (WMSDbContext dbContext = new WMSDbContext())
                    {
                        Sku sku = new Sku()
                        {
                            GUID = Guid.NewGuid(),
                            Unit = "头"
                        };
                        dbContext.Sku.Add(sku);
                        dbContext.SaveChanges();
                    }

                    using (CRMDbContext dbContext = new CRMDbContext())
                    {
                        User user = new User
                        {
                            UserName = "TransactionScope",
                            Password = "password",
                            CreateTime = DateTime.Now,
                            Status = 1

                        };

                        dbContext.User.Add(user);
                        dbContext.SaveChanges();
                    }
                    scope.Complete();
                    return 1;
                }
            }
            catch (Exception ex)
            {
                Log.Error<CheckOutManagerDal>(ex.ToString());
                return 0;
            }
        }

    }
}
