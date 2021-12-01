using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs.Lib.Abstract
{
    public abstract class Tüfek : Silah, IAtesEdebilen, ISarjorlu, ISeriAtabilir
    {
        protected int _sarjorKapasitesi, _kalanFisek, _atisKatsayisi;
        protected Stream _atisSesi, _bitikFisekSesi, _yenidenDoldurmaSesi;

        public int SarjorKapasitesi => _sarjorKapasitesi; //readonly propertyler bu şekilde yazılabilir. Bu propertye atanan value değeri = _sarjorKapasitesi yani bunu return edecek.

        public int KalanFisek => _kalanFisek;

        public int AtisKatsayisi => _atisKatsayisi;

        public Stream AtisSesi => _atisSesi;

        public Stream BitikFisekSesi => _bitikFisekSesi;

        public Stream YenidenDoldurmaSesi => _yenidenDoldurmaSesi;

        public abstract int AtesEt();

        public abstract int YenidenDoldur();
    }
}
