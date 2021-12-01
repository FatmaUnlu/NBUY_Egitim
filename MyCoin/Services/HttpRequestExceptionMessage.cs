using System.Net;
using System.Net.Http;

namespace MyCoin.Services
{
    internal class HttpRequestExceptionMessage : WebRequest
    {
        private HttpMethod get;
        private string baseUrl;

        public HttpRequestExceptionMessage(HttpMethod get, string baseUrl)
        {
            this.get = get;
            this.baseUrl = baseUrl;
        }
    }
}