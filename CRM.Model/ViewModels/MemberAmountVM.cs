using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Model.ViewModels
{
  public  class MemberAmountVM
    {
        /// <summary>
        /// 
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int MemberID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// 账号总金额
        /// </summary>
        public decimal TotalAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal TotalBonusPoints { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime ModifyTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte[] TimeStamp { get; set; }
    }
}
