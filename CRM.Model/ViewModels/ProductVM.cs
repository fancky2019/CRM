using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Model.ViewModels
{
    [Serializable]
    public class ProductVM
    {
        /// <summary>
        /// 
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Guid GUID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 折扣
        /// </summary>
        public short Discount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal BonusPoints { get; set; }

        public decimal _discountPrice;
        public decimal DiscountPrice
        {
            get
            {
                if (_discountPrice == 0)
                {
                    _discountPrice = Discount * Price/100;
                }
                return _discountPrice;
            }
        }


        private decimal _realityPrice;
        public decimal RealityPrice
        {
            get
            {
                if (_realityPrice == 0)
                {
                    _realityPrice = DiscountPrice;
                }
                return _realityPrice;
            }
            set
            {
                _realityPrice = value;
            }
        }

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
        /// <summary>
        /// 
        /// </summary>
        public short Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }


    }
}
