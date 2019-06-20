using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Model.EntityModels.CRM
{
    public class Deposit
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
        public decimal DepositAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal PayAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Remark { get; set; }
    }
}