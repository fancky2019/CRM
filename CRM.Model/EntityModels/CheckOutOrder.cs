using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Model.EntityModels
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
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ModifyTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public short Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public short Type { get; set; }
    }
}