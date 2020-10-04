using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.UI.Utilities
{
    public interface IHttpClientService
    {
        HttpClient ApiClient { get; set; }
        void InitializeClient();
    }
}
