using AccountManagement.UI.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AccountManagement.UI.ViewModels
{
    public class Management_Index_VM
    {
        private IApiHelper _apiHelper;
        public Management_Index_VM(IApiHelper apiHelper)
        {
            _apiHelper = apiHelper;

            PopulateList();

        }

        public int CustomerID { get; set; }
        public SelectList AllCustomers { get; set; }

        private async void PopulateList()
        {
            AllCustomers = await _apiHelper.GetCustomerSelectValues();
        }
    }
}