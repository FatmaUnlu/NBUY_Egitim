using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtımm
{
    public class Daire : Sekil
    {
        //constructor
        //public Daire()
        //{

        //}
        public Daire(double x) : base(x)
        {
            //this.x=x;
        }

        //properties
        //public double x { get; set; }

        //methots
        public override double AlanHesapla()
        {
            return Math.Pow(X, 2) * Math.PI;
        }

        public override double CevreHesapla()
        {
            return 2 * Math.PI * X;
        }

        public override double KosegenHesapla()
        {
            return 2 * X;
        }

        public double Cap()
        {
            return 2 * X;
        }
        public override string ToString() //lstSekillere yazdırmak için
        {
            return "Daire Alanı:" + Math.Round(AlanHesapla(),2)+ "br2"; 
        }
    }
}
