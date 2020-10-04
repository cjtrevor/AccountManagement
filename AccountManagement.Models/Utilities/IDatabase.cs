using AccountManagement.Models.Interfaces;
using System.Collections.Generic;

namespace AccountManagement.Models.Utilities
{
    public interface IDatabase
    {
        List<IAccount> Accounts { get; set; }
        List<ICustomer> Customers { get; set; }
        List<ITransaction> Transactions { get; set; }
    }
}