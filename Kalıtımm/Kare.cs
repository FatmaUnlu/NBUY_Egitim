using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtımm
{
    public class Kare : Sekil //kalıtım //Şeki clasında abstract bir metot olduğu için ctrl . yapıp implement yapmalıyız
    {

        //constructor : Yapılandırıcıların (constructor) görevi oluşturulan nesneyi ilk kullanıma hazırlamasıdır.
        //C# da tüm sınıflar (class) tanımlansın ya da tanımlanmasın değer tiplerine sıfır, referans tiplerine
        //"null" değerini atayan varsayılan bir yapılandırıcı vardır. Yapılandırıcısı tanımlandıktan sonra
        //varsayılan yapılandırıcı bir daha kullanılmaz. 
        //constructor iismi sınıf ile olmalı, açık bir dönüş tipi olmamalı genellikle 

        public Kare(double x) : base(x) // parametreli constructor olduğu için form kısmında nesne oluşturulurken parametre girmek zorundasın. Girmezsen hata verir
        {
           // this.x = x; //şuanki x girilen x'e eşit olsun demektir.
        }
        //şekilden constructor geliyo. o yüzden burda içteki kodu tekrar yazamayız. :base(x) ile burdaki const. işlemi zaten şekil 1 deki constructor işlemnine eşit olduğu için buraya gelen x'i  basedeki x'e yönlendir dedik.


        //public Kare() //parametresiz çalıştırmak istersek diye
        //{
           
        //}

        public override double AlanHesapla() //abstract yapınca şekil clasında bu metotu burası otomatik gelir
        {
            return X * X;
        }


        //class yazarken nesi var oyunu gibi yapmalısın. KArenin nesi var?
        //public double x { get; set; } //karenin bir kenarı   //kaltım ekleyice buna gerek yok.çünkü kalıtım yaptığımız sekil clasında bunlar var

        //public double AlanHesapla()
        //{
        //    return x * x;
        //}
        //public double CevreHesapla()
        //{
        //    return 4 * x;
        //}
        //public double KosegenHesapla()
        //{
        //    return x * Math.Sqrt(2);
        //}

        //kalıtım kullandığımız için bunlara gerek kalmadı. Şekil sınıfında hepsi var ve ondan miras aldık bunları çünkü


        public override string ToString()
        {
            return "Kare" + AlanHesapla() + "br2";
        }
    }
}
