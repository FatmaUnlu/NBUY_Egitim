using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoin.Services
{
    public interface IBinanceReq<T> where T : class //Tgeneric bir yapı olduğunu ifade eder. T nin içine yazılacaklarda class olsun.T tipi ne olursa resultın tipi o olacak
    {
        string BaseUrl { get; }
        T Result(string param); 
    }
}
