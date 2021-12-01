using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentMethod.Models.Payment.Models //uygulamayı yazdığımız yerde usinge yazıcaz
{
    public enum MessageStates : short //enum: numaralandırılımış liste, sabit listelelerde kullanılır. gizli bir şekildeint ten kalıtım almıştır
    {
        Success=999, //odanbaşlayarak gider defaultta. 
        Fail=111,
        Pending=666,
    }
}
