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
    public class CustomerService : ICustomerService
    {
        private IDatabase _database;
        public CustomerService(IDatabase database)
        {
            _database = database;
        }
        public List<ICustomer> GetCustomers()
        {
            return _database.Customers;
        }
    }
}
