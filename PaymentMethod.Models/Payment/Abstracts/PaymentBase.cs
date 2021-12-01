using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentMethod.Models.Payment.Abstracts
{
    public abstract class PaymentBase 
    {
        //ödeme için neye ihtiyaç var ? buclasın nesi var diye düşünüp yaz :)

        public string CustomerId { get; set; }
        public decimal Total { get; set; }
        public decimal TaxAmount { get; set; }


        //  public DateTime PaymentDate { get; private set; } = DateTime.Now;// private set ile dışarıdan erişimi kapatır manipüle vs edilemez bu şekilde. constructor içine yazıyoduk önceden eski alıştırmalarda var. bu yeni yöntem. seti kaldırabilirim öylesi de mümkün. 
        public DateTime PaymentDate { get;  } = DateTime.Now;


    }
}
