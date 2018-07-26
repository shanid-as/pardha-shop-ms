using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMS.Domain
{
    public class Customer
    {
        public long CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerNo { get; set; }
        public string Place { get; set; }
        public string PhoneNo1 { get; set; }
        public string PhoneNo2 { get; set; }
    }
}
