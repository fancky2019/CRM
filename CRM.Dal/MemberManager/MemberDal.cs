using CRM.Common;
using CRM.Dal;
using CRM.Model.EntityModels;
using CRM.Model.QueryModels;
using CRM.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CRM.Dal.MemberManager
{
    public class MemberDal
    {
        public (int Count, List<MemberVM> ListProductVM) LoadData(MemberQM qm)
        {
            try
            {
                using (CRMDbContext dbContext = new CRMDbContext())
                {
                    var result = from p in dbContext.Member
                                 select new MemberVM
                                 {
                                     ID = p.ID,
                                     UserName = p.UserName,
                                     Password = p.Password,
                                     PhoneNumber=p.PhoneNumber,
                                     IDCard=p.IDCard,
                                     Address=p.Address,
                                     CreateTime = p.CreateTime,
                                     ModifyTime = p.ModifyTime,
                                     Status = p.Status,
                                     Remark = p.Remark

                                 };
                    if (!string.IsNullOrEmpty(qm.UserName))
                    {
                        result = result.Where(p => p.UserName.Contains(qm.UserName));
                    }
                    if (!string.IsNullOrEmpty(qm.PhoneNumber))
                    {
                        result = result.Where(p => p.UserName.Contains(qm.PhoneNumber));
                    }
                    if (!string.IsNullOrEmpty(qm.IDCard))
                    {
                        result = result.Where(p => p.UserName.Contains(qm.IDCard));
                    }
                    var count = result.Count();
                    var list = result.OrderBy(p => p.CreateTime).Skip(qm.Skip).Take(qm.Take).ToList();
                    return (count, list);
                }
            }
            catch (Exception ex)
            {
                Log.Error<MemberDal>(ex.ToString());
                return (0, null);
            }
        }
        public int Add(Member member)
        {
            try
            {
                using (CRMDbContext dbContext = new CRMDbContext())
                {
                    dbContext.Member.Add(member);
                    dbContext.SaveChanges();
                    return 1;
                }
            }
            catch (Exception ex)
            {
                Log.Error<MemberDal>(ex.ToString());
                return 0;
            }
        }

        public int Update(Member member)
        {
            try
            {
                using (CRMDbContext dbContext = new CRMDbContext())
                {
                    Member pro = dbContext.Member.Where(p => p.ID == member.ID).FirstOrDefault();
                    pro.UserName = member.UserName;
                    pro.Password = member.Password;
                    pro.PhoneNumber = member.PhoneNumber;
                    pro.IDCard = member.IDCard;
                    pro.Address = member.Address;
                    pro.Remark = member.Remark;
                    pro.ModifyTime = DateTime.Now;
                    dbContext.SaveChanges();
                    return 1;
                }
            }
            catch (Exception ex)
            {
                Log.Error<MemberDal>(ex.ToString());
                return 0;
            }
        }

        public int Delete(Member member)
        {
            try
            {
                using (CRMDbContext dbContext = new CRMDbContext())
                {
                    Member pro = dbContext.Member.Where(p => p.ID == member.ID).FirstOrDefault();
                    dbContext.Member.Remove(pro);
                    dbContext.SaveChanges();
                    return 1;
                }
            }
            catch (Exception ex)
            {
                Log.Error<MemberDal>(ex.ToString());
                return 0;
            }
        }

        public bool Exist(Member member)
        {
            try
            {
                using (CRMDbContext dbContext = new CRMDbContext())
                {
                    return dbContext.Member.Any(p => p.PhoneNumber == member.PhoneNumber);
                }
            }
            catch (Exception ex)
            {
                Log.Error<MemberDal>(ex.ToString());
                return true;
            }
        }

        public Member GetMemberByPhoneNumber(string phoneNumber)
        {
            try
            {
                using (CRMDbContext dbContext = new CRMDbContext())
                {
                     return dbContext.Member.FirstOrDefault(p => p.PhoneNumber == phoneNumber);
                }
            }
            catch (Exception ex)
            {
                Log.Error<MemberDal>(ex.ToString());
                return null;
            }
        }
        public List<MemberVM> QueryWithNoPage(MemberQM qm)
        {
            try
            {
                using (CRMDbContext dbContext = new CRMDbContext())
                {
                    var result = from p in dbContext.Member
                                 select new MemberVM
                                 {
                                     ID = p.ID,
                                     UserName = p.UserName,
                                     Password = p.Password,
                                     PhoneNumber = p.PhoneNumber,
                                     IDCard = p.IDCard,
                                     Address = p.Address,
                                     CreateTime = p.CreateTime,
                                     ModifyTime = p.ModifyTime,
                                     Status = p.Status,
                                     Remark = p.Remark

                                 };
                    if (!string.IsNullOrEmpty(qm.UserName))
                    {
                        result = result.Where(p => p.UserName.Contains(qm.UserName));
                    }
                    if (!string.IsNullOrEmpty(qm.PhoneNumber))
                    {
                        result = result.Where(p => p.PhoneNumber.Contains(qm.PhoneNumber));
                    }
                    if (!string.IsNullOrEmpty(qm.IDCard))
                    {
                        result = result.Where(p => p.IDCard.Contains(qm.IDCard));
                    }
                    return result.ToList();
                }
            }
            catch (Exception ex)
            {
                Log.Error<MemberDal>(ex.ToString());
                return null;
            }
        }
    }
}
