using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace PSMS.Models
{
    public class CustomerModel
    {
        [DisplayName("Customer Id")]
        public long CustomerId { get; set; }
        [DisplayName("Customer Name")]
        public string CustomerName { get; set; }
        [DisplayName("Customer #")]
        public string CustomerNo { get; set; }
        [DisplayName("Place")]
        public string Place { get; set; }
        [DisplayName("Phone #1")]
        public string PhoneNo1 { get; set; }
        [DisplayName("Phone #2")]
        public string PhoneNo2 { get; set; }
    }
}