using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSMS.Areas.Order.Models
{
    public class BookingModel
    {
        public long BookingId { get; set; }
        public string BookingNo { get; set; }
        public long CustomerId { get; set; }
        public long MeasurementId { get; set; }
        public long PreferenceId { get; set; }
        public decimal Amount { get; set; }
        public decimal AdvanceAmount { get; set; }
    }
}