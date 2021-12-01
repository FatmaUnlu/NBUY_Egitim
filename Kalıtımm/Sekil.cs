using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtımm
{
    
    public abstract class Sekil //baseclass
        //abstract olması sayesinde Sekil s1 = new Sekil() yazınca newsekil kısmının altını çizer.Şekil clasının newlwnmwsini önlemiş olduk

    {

        public Sekil(double x)
        {
            this.X = x;
        }

        private double _x;


        public  double X
        {
            get { return _x; }
                 
            set
            {
                if (value <= 0)
                    throw new Exception("x 0'dan büyük olmalıdır");
                    _x = value;
            }
        } //başka biyerde set etmek istenirse diye virtual konulabilir başına. kalıtım verilen yerde değiştirilme ihtimali varsa

        //public virtual double AlanHesapla() //nesneyi sanallaştırma virtual ile.  isteyen bu şekilde                                kullansın istemeyen override ile ezip başka şekilde kullansın diye.
        //{
        //    return x * x;
        //}

        public abstract double AlanHesapla(); //abstract kullandığımız için şekil clasından gelen alan hesapla metodunu kullanmak isteyen kişi kullanacağı yerde yazmak zorundadır. nasıl olacagını kullanacak kişi tanımlar
        
        public virtual double CevreHesapla() //virtual ile sen tanımlıyosun ama isteyen bunu kullanır isteyen override ile kendi istediği şekilde değiştirwbilir
        {
            return 4 * X;
        }
        public  virtual double KosegenHesapla()
        {
            return Math.Sqrt(2) * X;
        }


    }
}
