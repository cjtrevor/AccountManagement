using AccountManagement.Models.Implementations;
using AccountManagement.UI.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountManagement.UI.ViewModels
{
    public class Management_Transactions_VM
    {
        private IApiHelper _apiHelper;
        public List<Transaction> Transactions { get; set; }
        public string AccountNumber { get; set; }
        public Guid AccountID { get; set; }

        public Management_Transactions_VM(IApiHelper apiHelper, Guid accountID, string accountNumber)
        {
            _apiHelper = apiHelper;
            AccountID = accountID;
            AccountNumber = accountNumber;

            Populate(accountID);
        }
        public async void Populate(Guid AccountID)
        {
            Transactions = await _apiHelper.GetTransactions(AccountID);
        }
    }
}