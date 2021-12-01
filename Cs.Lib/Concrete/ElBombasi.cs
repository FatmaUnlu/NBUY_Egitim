using Cs.Lib.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs.Lib.Concrete
{
    public class ElBombasi : Firlatilen
    {
        public ElBombasi()
        {
            this.Ulke = "İspanya";
            this.Hasar = 120;
            this.Fiyat = 400;
           
            this.SilahResim = new MemoryStream(Properties.Resources.Bomba);
            this._bombaSesi = Properties.Resources.Bomb;
            

        }

        public override int Firlat()
        {
            this._bombaSesi = Properties.Resources.Bomb;
            return Hasar;
        }
    }
}
