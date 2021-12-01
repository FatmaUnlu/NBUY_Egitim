using PaymentMethod.Models.Payment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentMethod.Models.Payment.Abstracts
{
    public interface IPayable //bütün ödeme sistemlerine bu interface üzerinden gidilecek
    {
        //interface de farklı bir interfaceden de değer alabiliriz fakat claasslardan alamayız. Çünkü soyut bir şeyin içine somut bir şey atılmaz. Abstractan alınması teknik olarak mümkün ama güvenlik açığı oluşturur.

        //Diğer sınıflara yol göstericilik yapması için oluşturulur. Kendisinden implement edilen bir sınıfa doldurulması zorunlu olan bazı özelliklerin aktarılmasını sağlar 

        //I harfi ile başlarlar Genelde sonuna able gelir.

        // Private ifadesi yer alamaz içinde.


       // void Pay(decimal payment);
        void Pay(PaymentBase payment); // Bir Pay tanımlayayım hepsinde çalışsın ve PaymentBase tipinde olan bir nesneyle çalışsın

        MessageStates State { get; set; } //Yapılan işin durumu olsun

        //Interface de yer alan bu Pay ve State kısımları Manager kısımlarında IPayable ile gevşek bağ yapılmış
    }
}
