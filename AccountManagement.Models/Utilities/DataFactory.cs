using AccountManagement.Models.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Models.Utilities
{
    public class DataFactory : IDataFactory
    {
        public Customer CreateCustomer()
        {
            return new Customer();
        }

        public Account CreateAccount()
        {
            return new Account();
        }
        public Transaction CreateTransaction()
        {
            return new Transaction();
        }
    }
}
