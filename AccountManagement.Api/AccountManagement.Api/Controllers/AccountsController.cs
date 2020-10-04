using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AccountManagement.Models.Interfaces;
using AccountManagement.Services.Interfaces;
using Newtonsoft.Json;

namespace AccountManagement.Api.Controllers
{
    /// <summary>
    /// This controller enables the management of accounts belonging to customers.
    /// </summary>
    public class AccountsController : ApiController
    {
        private IAccountService _accountService;
        private ITransactionService _transactionService;
        public AccountsController(IAccountService accountService, ITransactionService transactionService)
        {
            _accountService = accountService;
            _transactionService = transactionService;
        }
        // GET: api/Accounts
        /// <summary>
        /// Not yet implemented
        /// </summary>
        /// <returns></returns>
        public List<IAccount> Get()
        {
            return _accountService.GetAccounts();
        }

        // GET: api/Accounts/5
        /// <summary>
        /// Not yet implemented
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<IAccount> Get(Guid id)
        {
            return _accountService.GetAccounts().Where(x => x.CustomerID == id).ToList();
        }

        // POST: api/Accounts
        /// <summary>
        /// This allows the creation of a new account for a specified customer
        /// </summary>
        public void Post(Guid CustomerID, decimal Balance)
        {
            Guid AccountID = _accountService.InsertNewAccount(CustomerID, Balance);

            if (Balance != 0)
                _transactionService.InsertNewTransaction(AccountID, Balance);
        }

        // PUT: api/Accounts/5
        /// <summary>
        /// Not yet implemented
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public void Put(int id, [FromBody] string value)
        {
            throw new NotImplementedException();
        }

        // DELETE: api/Accounts/5
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
