using PaymentMethod.Models.Payment.Abstracts;
using PaymentMethod.Models.Payment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentMethod.Models.Payment.Managers
{
    public class CreditPaymentManager : IPayable
    {
        public MessageStates State { get; set ; }

        public void Pay(PaymentBase payment)
        {
            try
            {
                //ödeme ayarları yapılır

                CreditPayment credit = payment as CreditPayment; //credit değişkenini CreditPayment gibi yap, onun gibi davran.  Tür dönüşümü gibi düşün (int ten stringe dönme mesela).  Artık onun gibi davranıyor. as: bir türden diğer bir türe dönüşüm için kullanılan bir anahtar kelime.

                State = MessageStates.Success;

                //db işlemleri
                //bildirim işlemleri
                //log işlemleri
            }
            catch (Exception)
            {
                //log işlemleri
                //bildirim
                State = MessageStates.Fail;
            }
        }
    }
}
