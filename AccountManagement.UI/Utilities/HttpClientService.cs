using System.Net.Http;
using System.Net.Http.Headers;

namespace AccountManagement.UI.Utilities
{
    public class HttpClientService : IHttpClientService
    {
        public HttpClient ApiClient { get; set; }

        public HttpClientService()
        {
            InitializeClient();
        }

        public void InitializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
