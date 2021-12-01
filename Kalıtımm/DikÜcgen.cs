using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtımm
{
    public class DikÜcgen : Dikdörtgen
    {

        public DikÜcgen(double x, double y) : base(x,y)
        {

        }
        public override double AlanHesapla() // bu metotlar dikdörtgende override edilmediyse sekilden alır işlem şeklini
        {
            return base.AlanHesapla() / 2; //base. lı kısım Alan hesaplamanın dikdörtgendeki gibi çalışmasını sağlar.  burada alanhesaplanın üstüne gelip f12 basarak hangi classtan kalıtım aldıysak ona götürür
        }
        public override double CevreHesapla()
        {
            return base.CevreHesapla()/2 + base.KosegenHesapla();
            
        }
       

        public override string ToString()
        {
            return "Dik Üçgen:" + AlanHesapla()+"br2";
        }
    }
}
