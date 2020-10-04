using AccountManagement.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Services.Interfaces
{
    public interface IAccountService
    {
        Guid InsertNewAccount(Guid CustomerID, decimal Balance);
        List<IAccount> GetAccounts();
    }
}
