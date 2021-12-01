using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoin.utils
{
    public static class BinanceHelper
    {
        public static DateTime DateConverter(long tick)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc); //saniye hatalı görüyordu onun için bunu yazdık
            return epoch.AddMilliseconds(tick).ToLocalTime();
        }
    }
}
