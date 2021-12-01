using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MyCoin.Services
{
    public class ExchangeInfoServices : IBinanceReq<BinanceReqExchangeBody>
    {
        // public const string BaseUrl = "https://api.binance.com/api/v3/exchangeInfo"; //sadece tanımlandığı yerde değiştirilebilen bir değişken tipi oluştırırsunuz.

        public string BaseUrl => "https://api.binance.com/api/v3/exchangeInfo";

        //public BinanceReqExchangeBody Result { get; set; }



        public BinanceReqExchangeBody Result(string param = null)
        {
            HttpClient client = new HttpClient(); //web isteklerini yönetmek için küçük bir tarayıcı kurduk.
            try
            {
                HttpResponseMessage result = client.GetAsync(new Uri(BaseUrl)).Result; //url Nin / / verilen haline uri denir.Yukarıdki linkler gibi
                if (result.StatusCode != HttpStatusCode.OK)
                    throw new Exception($"İstek başarısız: {result.StatusCode}");

                BinanceReqExchangeBody body =
                    JsonConvert.DeserializeObject<BinanceReqExchangeBody>(result.Content.ReadAsStringAsync().Result);
                return body;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}


