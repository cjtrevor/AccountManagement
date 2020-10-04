using AccountManagement.UI.Utilities;
using AccountManagement.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AccountManagement.UI.Controllers
{
    public class ManagementController : Controller
    {
        private IApiHelper _apiHelper;
        public ManagementController(IApiHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }
        // GET: Management
        public async Task<ActionResult> Index()
        {
            Management_Index_VM VM = new Management_Index_VM(_apiHelper);
            return View(VM);
        }

        [HttpPost]
        public async Task<ActionResult> Accounts(Guid CustomerID)
        {
            Management_Accounts_VM VM = new Management_Accounts_VM(_apiHelper, CustomerID);
            return View(VM);
        }

        public async Task<ActionResult> Transactions(Guid AccountID, string AccountNumber)
        {
            Management_Transactions_VM VM = new Management_Transactions_VM(_apiHelper, AccountID, AccountNumber);
            return View(VM);
        }

        [HttpPost]
        public async Task<ActionResult> NewAccount(Guid CustomerID, decimal StartingBalance = 0)
        {
            _apiHelper.InsertNewAccount(CustomerID, StartingBalance);

            Management_Accounts_VM VM = new Management_Accounts_VM(_apiHelper, CustomerID);
            return View("Accounts", VM);
        }
    }
}