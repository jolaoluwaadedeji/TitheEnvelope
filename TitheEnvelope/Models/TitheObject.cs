using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TitheEnvelope.Models
{
    public class TitheObject
    {
        public long Id { get; set; }
        public string NameOfTither { get; set; }
        public string DateOfPayment { get; set; }
        public decimal Amount { get; set; }
        public string MonthOfTithe { get; set; }
        public string PaymentType { get; set; }

    }
}
