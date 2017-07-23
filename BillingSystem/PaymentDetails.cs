using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem
{
    public class PaymentDetails
    {
        public decimal TotalAmount { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal AmountReceived { get; set; }
        public decimal Balance { get; set; }
        public decimal Cash { get; set; }
        public decimal Card { get; set; }
        public decimal NetTransfer { get; set; }
        public decimal WriteOff { get; set; }
    }
}
