﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs.Lib.Abstract
{
    public interface ISarjorlu // şarjörlünün nesi var?
    {
        int SarjorKapasitesi { get; }
        int KalanFisek { get; }
        int YenidenDoldur();

        Stream YenidenDoldurmaSesi { get; }
        

    }
}
