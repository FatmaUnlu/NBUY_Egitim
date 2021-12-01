using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs.Lib.Abstract
{
    public abstract class Tabanca : Silah, IAtesEdebilen, ISarjorlu //ikisi de abstract oldğu için ezme yapmaya gerek yok.
    {
        protected int _sarjorKapasitesi, _kalanFisek;
        protected Stream _atisSesi, _bitikFisekSesi, _yenidenDoldurmaSesi;
        

        public int SarjorKapasitesi => _sarjorKapasitesi; //readonly propertyler (get{return _sarjorKapasitesi} )bu şekilde yazılabilir. Bu propertye atanan value değeri = _sarjorKapasitesi yani bunu return edecek.

        public int KalanFisek => _kalanFisek;

        public Stream AtisSesi => _atisSesi;     

        public Stream BitikFisekSesi => _bitikFisekSesi;

        public Stream YenidenDoldurmaSesi => _yenidenDoldurmaSesi;

        

        public abstract int AtesEt();

        public abstract int YenidenDoldur();
        
    }
}
