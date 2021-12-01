using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs.Lib.Abstract
{
   public interface IFirlatilabilen  
    {
        int Firlat();
        Stream BombaSesi { get; }
        Stream FlashBombasiSesi { get; }
        
    }
}
