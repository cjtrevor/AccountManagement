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
    public class TransactionService : ITransactionService
    {
        private IDatabase _database;
        private IDataFactory _dataFactory;
        public TransactionService(IDatabase database, IDataFactory dataFactory)
        {
            _database = database;
            _dataFactory = dataFactory;
        }

        public List<ITransaction> GetTransactions()
        {
            return _database.Transactions;
        }

        public List<ITransaction> GetTransactionsByAccountID(Guid AccountID)
        {
            return _database.Transactions.Where(x => x.AccountID == AccountID).ToList();
        }

        public void InsertNewTransaction(Guid AccountID, decimal Amount)
        {
            var newTransaction = _dataFactory.CreateTransaction();
            newTransaction.TransactionID = Guid.NewGuid();
            newTransaction.TransactionDate = DateTime.Now;
            newTransaction.AccountID = AccountID;
            newTransaction.TransactionAmount = Amount;

            _database.Transactions.Add(newTransaction);
        }
    }
}
