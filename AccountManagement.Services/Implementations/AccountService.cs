using AccountManagement.Models.Interfaces;
using AccountManagement.Models.Utilities;
using AccountManagement.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Services.Implementations
{
    public class AccountService : IAccountService
    {
        private IDatabase _database;
        private IDataFactory _dataFactory;
        public AccountService(IDatabase database, IDataFactory datafactory)
        {
            _database = database;
            _dataFactory = datafactory;
        }

        public List<IAccount> GetAccounts()
        {
            return _database.Accounts;
        }

        public Guid InsertNewAccount(Guid CustomerID, decimal Balance)
        {
            var newAccount = _dataFactory.CreateAccount();
            newAccount.AccountID = Guid.NewGuid();
            newAccount.CustomerID = CustomerID;
            newAccount.AccountNumber = GenerateAccountNumber();
            newAccount.Balance = Balance;

            _database.Accounts.Add(newAccount);

            return newAccount.AccountID;
        }

        private string GenerateAccountNumber()
        {
            Random random = new Random();
            string r = "";
            int i;
            for (i = 1; i < 11; i++)
            {
                r += random.Next(0, 9).ToString();
            }
            return r;
        }
    }
}
