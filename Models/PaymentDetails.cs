using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject1.Models
{
    public class PaymentDetails
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CardName { get; set; }
        public string CardInfo { get; set; }

        public string SecurityCode { get; set; }
    }
}
