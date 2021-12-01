using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs.Lib.Abstract
{
    public abstract class YakinSaldiri : Silah, IVurulabilir
    {
        protected int _vurusKatsayisi;

        protected Stream _bicakCikarmaSesi, _bicakSaplamaSesi;

         public int VurusKatsayisi => _vurusKatsayisi;
       
      
        public Stream BicakCikarmaSesi => _bicakCikarmaSesi;
      
        public Stream BicakSaplamaSesi => _bicakSaplamaSesi;


        //public int VurusKatsayisi { get { return _vurusKatsayisi; } } yukarıdakinin açık hali

        public abstract int Vur();
        
    }
}
