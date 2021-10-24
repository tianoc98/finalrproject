using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject1.Models
{
    public class PaymentData
    {
        public int Id { get; set; }
        public double Pay { get; set; }
        public string DetailsPayment { get; set; }
        public string CustomerName { get; set; }

        public DateTime PaymentDate { get; set; }
    }
}
