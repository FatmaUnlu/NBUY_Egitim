using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs.Lib.Abstract
{
    public interface IVurulabilir
    {
        int VurusKatsayisi { get; }
        int Vur();
        Stream BicakCikarmaSesi { get; }
        Stream BicakSaplamaSesi { get; }
    }
}
