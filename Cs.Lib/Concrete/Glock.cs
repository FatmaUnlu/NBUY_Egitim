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
    public sealed class Glock : Tabanca //sealed ilglili classın kalıtım vermesini önlemek için kullanılır. Calsın artık en son class olduğunu düşünüyorsak ve artık kalıtımı kapatmaya karar verdiyse bu komut kullanılır.

    {
        public Glock()
        {
            this._sarjorKapasitesi = 20;
            this.Ulke = "Avusturya";
            this.Hasar = 24;
            this.Fiyat = 200m;
            this._kalanFisek = this.SarjorKapasitesi ;
            this.SilahResim = new MemoryStream(Properties.Resources.Glock1);
            this._atisSesi = Properties.Resources.Glock_Ates;
            this._bitikFisekSesi = Properties.Resources.Bitik_Mermi_Sesi;
            this._yenidenDoldurmaSesi = Properties.Resources.Glock_Reload;
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
