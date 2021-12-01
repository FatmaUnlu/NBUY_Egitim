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
    public class Bicak : YakinSaldiri
    {
        public Bicak()
        {
            this.Ulke = "Türkiye";
            this.Hasar = 10;
            this.Fiyat = 20;
            this._vurusKatsayisi = 2;
            this.SilahResim = new MemoryStream(Properties.Resources.Bicak1);
            this._bicakCikarmaSesi = Properties.Resources.Bicak_Cikarma;
           //this._bicakSaplamaSesi = Properties.Resources.Bicak_Saplama;

        }
        public override int Vur()
        {
            this._bicakSaplamaSesi = Properties.Resources.Bicak_Saplama;
            Thread.Sleep(VurusKatsayisi);
            return Hasar;
        }
    }
}
