using AccountManagement.Models.Implementations;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AccountManagement.UI.Utilities
{
    public class ApiHelper : IApiHelper
    {
        public string ApiRoot
        {
            get
            {
                return ConfigurationManager.AppSettings["ApiRoot"];
            }
        }

        IHttpClientService _httpClientService;
        public ApiHelper(IHttpClientService httpClientService)
        {
            _httpClientService = httpClientService;
        }
        public async Task<SelectList> GetCustomerSelectValues()
        {
            //url
            string url = $"{ApiRoot}/api/customers";

            //response
            using (var response = _httpClientService.ApiClient.GetAsync(url))
            {
                if (response.Result.IsSuccessStatusCode)
                {
                    var SelectResponse = JsonConvert.DeserializeObject<List<Customer>>(await response.Result.Content.ReadAsStringAsync());

                    List<SelectListItem> Items = SelectResponse.Select(x => new SelectListItem() { Text = $"{x.FirstName} {x.Surname}", Value = x.CustomerID.ToString() }).ToList();

                    return new SelectList(Items, "Value", "Text");
                }
            }

            return null;
        }

        public async Task<List<Account>> GetCustomerAccounts(Guid CustomerID)
        {
            //url
            string url = $"{ApiRoot}/api/accounts/{CustomerID}";

            //response
            using (var response = _httpClientService.ApiClient.GetAsync(url))
            {
                if (response.Result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<List<Account>>(await response.Result.Content.ReadAsStringAsync());
                }
            }

            return null;
        }

        public async Task<string> GetCustomerName(Guid CustomerID)
        {
            //url
            string url = $"{ApiRoot}/api/customers/{CustomerID}";

            //response
            using (var response = _httpClientService.ApiClient.GetAsync(url))
            {
                if (response.Result.IsSuccessStatusCode)
                {
                    var Customer = JsonConvert.DeserializeObject<Customer>(await response.Result.Content.ReadAsStringAsync());

                    return $"{Customer.FirstName} {Customer.Surname}";
                }
            }

            return null;
        }

        public void InsertNewAccount(Guid CustomerID, decimal StartingBalance)
        {
            string url = $"{ApiRoot}/api/Accounts?CustomerID={CustomerID}&Balance={StartingBalance}";

            using (var response = _httpClientService.ApiClient.PostAsync(url, null))
            {
                if (response.Result.IsSuccessStatusCode)
                {
                }
            }
        }

        public async Task<List<Transaction>> GetTransactions(Guid AccountID)
        {
            //url
            string url = $"{ApiRoot}/api/transactions/{AccountID}";

            //response
            using (var response = _httpClientService.ApiClient.GetAsync(url))
            {
                if (response.Result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<List<Transaction>>(await response.Result.Content.ReadAsStringAsync());
                }
            }

            return null;
        }
    }
}