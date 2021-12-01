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
    public class M4A1S : Tüfek
    {

        public M4A1S()
        {
            this._sarjorKapasitesi = 20;
            this.Ulke = "Avusturya";
            this.Hasar = 24;
            this.Fiyat = 200m;
            this._atisKatsayisi = 5;
            this._kalanFisek = this.SarjorKapasitesi;
            this.SilahResim = new MemoryStream(Properties.Resources.M4A1S1);
            this._atisSesi = Properties.Resources.M4A1_Ates;
            this._bitikFisekSesi = Properties.Resources.Bitik_Mermi_Sesi;
            this._yenidenDoldurmaSesi = Properties.Resources.M4A1_Reload;
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
