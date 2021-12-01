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
    public class SymbolTickerService : IBinanceReq<BinanceReq224HTick>
    {
        // public string BaseUrl => throw new NotImplementedException();
        public string BaseUrl { get; } = "https://api.binance.com/api/v3/ticker/24hr";
        public BinanceReq224HTick Result(string param)
        {
            HttpClient client = new HttpClient();
           // HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, BaseUrl);
            try
            {

                var query = $"{BaseUrl}?symbol={param}";//cok parametre gönderince bu yöntem zor oluyo
                                                        //client.GetAsync(new Uri(BaseUrl));

                // HttpResponseMessage resp = client.GetAsync(request).Result;

                HttpResponseMessage resp = client.GetAsync(query).Result;
                if (resp.StatusCode != HttpStatusCode.OK)
                    throw new Exception($"istek başarısız: {resp.StatusCode}");

                //request.Content = new FormUrlEncodedContent(new Dictionary<string, string>
                //{
                //    {"symbol",param }
                //});

                BinanceReq224HTick resultTicker = JsonConvert.DeserializeObject<BinanceReq224HTick>(resp.Content.ReadAsStringAsync().Result);
                return resultTicker;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
