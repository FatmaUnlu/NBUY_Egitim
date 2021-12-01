using PaymentMethod.Models.Payment.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentMethod.Models.Payment.Models
{
    public class CreditPayment : PaymentBase
    {
        public int Installment { get; set; }

        public decimal Commision { get; set; }

        public Card CardInfo { get; set; }
    }
}
