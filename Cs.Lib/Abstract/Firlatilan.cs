using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs.Lib.Abstract
{
    public abstract class Firlatilen : Silah, IFirlatilabilen
    {
        protected Stream _bombaSesi,_flashBombasiSesi;
        public Stream BombaSesi => _bombaSesi;

        public Stream FlashBombasiSesi => _flashBombasiSesi;
        public abstract int Firlat();
        
    }
}
