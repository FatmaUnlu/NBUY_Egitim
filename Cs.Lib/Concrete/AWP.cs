using Cs.Lib.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cs.Lib.Concrete
{
    public class AWP : Tüfek
    {
        public AWP()
        {
            this._sarjorKapasitesi = 5;
            this.Ulke = "Almanya";
            this.Hasar = 45;
            this.Fiyat = 5000;
            this._atisKatsayisi =2;
            this._kalanFisek = this.SarjorKapasitesi;
            this.SilahResim = new MemoryStream(Properties.Resources.AWP1);
            this._atisSesi = Properties.Resources.AWP_Ates;
            this._bitikFisekSesi = Properties.Resources.Bitik_Mermi_Sesi;
           // this._yenidenDoldurmaSesi = Properties.Resources.AWP_Load;
        }
        public override int AtesEt()
        {
            if (KalanFisek != 0)
            {
                this._kalanFisek--;
            }
            Thread.Sleep(300);
            return this._kalanFisek;
        }

        public override int YenidenDoldur()
        {
            this._kalanFisek = this.SarjorKapasitesi;
            Thread.Sleep(1000);
            return KalanFisek;
        }
    }
}
