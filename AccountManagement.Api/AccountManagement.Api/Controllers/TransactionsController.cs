using AccountManagement.Models.Interfaces;
using AccountManagement.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AccountManagement.Api.Controllers
{
    /// <summary>
    /// This controller allows the management of transactions for existing accounts
    /// </summary>
    public class TransactionsController : ApiController
    {
        private ITransactionService _transactionService;
        public TransactionsController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }
        // GET: api/Transactions
        /// <summary>
        /// Not yet implemented
        /// </summary>
        /// <returns></returns>
        public List<ITransaction> Get()
        {
            return _transactionService.GetTransactions();
        }

        // GET: api/Transactions/5
        /// <summary>
        /// This returns a list of all the transactions for a specified account
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<ITransaction> Get(Guid id)
        {
            return _transactionService.GetTransactionsByAccountID(id);
        }

        // POST: api/Transactions
        /// <summary>
        /// This allows the inserting of a new transaction for a specified account
        /// </summary>
        /// <param name="value"></param>
        public void Post(Guid AccountID, decimal TransactionAmount)
        {
            _transactionService.InsertNewTransaction(AccountID, TransactionAmount);
        }

        // PUT: api/Transactions/5
        /// <summary>
        /// Not yet implemented
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public void Put(int id, [FromBody] string value)
        {
            throw new NotImplementedException();
        }

        // DELETE: api/Transactions/5
        /// <summary>
        /// Not yet implemented
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
