using AccountManagement.Models.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AccountManagement.UI.Utilities
{
    public interface IApiHelper
    {
        Task<SelectList> GetCustomerSelectValues();
        Task<List<Account>> GetCustomerAccounts(Guid CustomerID);
        Task<string> GetCustomerName(Guid CustomerID);
        Task<List<Transaction>> GetTransactions(Guid AccountID);
        void InsertNewAccount(Guid CustomerID, decimal StartingBalance);
    }
}
