using AccountManagement.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Services.Interfaces
{
    public interface ITransactionService
    {
        void InsertNewTransaction(Guid AccountID, decimal Amount);
        List<ITransaction> GetTransactionsByAccountID(Guid AccountID);

        List<ITransaction> GetTransactions();
    }
}
