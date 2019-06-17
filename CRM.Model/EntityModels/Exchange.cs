using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Model.EntityModels
{
    public class Exchange
    {
        /// <summary>
        /// 
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int MemmberID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal BonusPonitAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal Money { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CreateTime { get; set; }
    }
}