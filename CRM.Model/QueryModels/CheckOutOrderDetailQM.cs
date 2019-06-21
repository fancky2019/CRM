using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Model.QueryModels
{
    public class CheckOutOrderDetailQM : PageInfo
    {

        public int CheckOutOrderID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }

        public string ProductName { get; set; }
    }
}
