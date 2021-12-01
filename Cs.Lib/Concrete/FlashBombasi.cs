using Cs.Lib.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs.Lib.Concrete
{
    public class FlashBombasi : Firlatilen
    {
        public FlashBombasi()
        {
            this.Ulke = "Avusturya";
            this.Hasar = 250;
            this.Fiyat = 750;

            this.SilahResim = new MemoryStream(Properties.Resources.Flash);
            this._bombaSesi = Properties.Resources.Bomb;


        }

        public override int Firlat()
        {
            this._bombaSesi = Properties.Resources.Flashbang;
            return Hasar;
        }
       
    }
}
