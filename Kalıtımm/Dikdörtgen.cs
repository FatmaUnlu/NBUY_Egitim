using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtımm
{
    public class Dikdörtgen : Sekil
    {
        //constructor
        public Dikdörtgen(double x, double y) : base(x) //xi şekildeki constructora yönlendirdik zaten orda da olduğu için
        {
            //this.x = x;
            this.Y = y;
        }

        //public Dikdörtgen()
        //{

        //}
        //properties
        //public double x { get; set; } x şekil calısnda var zaten ve kalıtım aldıpımız için yeniden yazmamıza gerek yok
        public double Y { get; set; }
         

        //methot
        public override double AlanHesapla() //virtual ile şekil kalıtımından dolayı y yi kullanamamamız sebebiyle override yaptık ve diğer alan hesaplayı ezmiş olduk şekildeki
        {
            return X * Y;
        }
        public override double CevreHesapla()
        {
            return 2 * (X + Y);
        }
        public override double KosegenHesapla()
        {
            return (Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y,2)));
        }

        public override string ToString()
        {
            return "Dikdörtgen Alanı:" + AlanHesapla()+"br2";
        }
    }
}
