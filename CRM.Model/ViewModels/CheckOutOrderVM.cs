using CRM.Model.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Model.ViewModels
{
    public class CheckOutOrderVM
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

        public List<Product> Products { get; set; }
    }
}
