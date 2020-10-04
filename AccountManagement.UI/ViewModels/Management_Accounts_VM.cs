using AccountManagement.Models.Implementations;
using AccountManagement.UI.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountManagement.UI.ViewModels
{
    public class Management_Accounts_VM
    {
        private IApiHelper _apiHelper;
        public List<Account> Accounts { get; set; }
        public string CustomerName { get; set; }
        public Guid customerID { get; set; }
        public decimal StartingBalance { get; set; }

        public Management_Accounts_VM(IApiHelper apiHelper, Guid CustomerID)
        {
            _apiHelper = apiHelper;
            customerID = CustomerID;
            Populate(CustomerID);
        }

        public async void Populate(Guid CustomerID)
        {
            CustomerName = await _apiHelper.GetCustomerName(CustomerID);
            Accounts = await _apiHelper.GetCustomerAccounts(CustomerID);
        }
    }
}