using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs.Lib.Abstract
{
    public abstract class Silah //her silahın nesi var? diye sorunca gerekli propertyleri bulursun.
    {
        public string Ulke { get; protected set; } //kalıtım aldığı her yerde st edilebilir fakat instance aldığı yerde set edilemez
        public decimal Fiyat { get; protected set; }
        public int Hasar { get; protected set; }

        public Stream SilahResim { get; protected set; }

    }

   
    public enum Silahlar : byte //256 silah tanımlayabiliriz : byte ile.
    {
        Bıçak,
        USP,
        Glock,
        AK47,
        M4A1S,
        AWP,
        ElBombası,
        FlashBombası
    };
}
