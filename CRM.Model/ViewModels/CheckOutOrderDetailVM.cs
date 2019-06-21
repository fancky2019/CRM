using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Model.ViewModels
{
    public class CheckOutOrderDetailVM
    {
        /// <summary>
        /// 
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int CheckOutOrderID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ProductID { get; set; }

        public string ProductName { get; set; }
        public decimal Price { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public short Discount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal DiscountPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal RealityPrice { get; set; }
        /// <summary>
        /// 积分
        /// </summary>
        public decimal BonusPoints { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CreateTime { get; set; }
    }
}
