using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Model.EntityModels.CRM
{
    public class CheckOutOrder
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
        public short Status { get; set; }
        /// <summary>
        /// 付款方式：0：现金，1：积分
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime ModifyTime { get; set; }
    }
}