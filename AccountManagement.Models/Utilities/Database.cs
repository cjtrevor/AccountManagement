using AccountManagement.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Models.Utilities
{
    /// <summary>
    /// This class is only here to imitate a DataContext. It is simpler to store a single object in memory than to keep track of multiple ones.
    /// </summary>
    public class Database : IDatabase
    {
        public List<ICustomer> Customers { get; set; }
        public List<IAccount> Accounts { get; set; }
        public List<ITransaction> Transactions { get; set; }

        private IDataFactory _dataFactory;
        public Database(IDataFactory dataFactory)
        {
            _dataFactory = dataFactory;
            ConfigureStartupData();
        }

        private void ConfigureStartupData()
        {
            Customers = new List<ICustomer>();
            Accounts = new List<IAccount>();
            Transactions = new List<ITransaction>();

            var exCustomer1 = _dataFactory.CreateCustomer();
            exCustomer1.CustomerID = Guid.NewGuid();
            exCustomer1.FirstName = "Peter";
            exCustomer1.Surname = "Parker";
            Customers.Add(exCustomer1);

            var exCustomer2 = _dataFactory.CreateCustomer();
            exCustomer2.CustomerID = Guid.NewGuid();
            exCustomer2.FirstName = "Clark";
            exCustomer2.Surname = "Kent";
            Customers.Add(exCustomer2);

            var exCustomer3 = _dataFactory.CreateCustomer();
            exCustomer3.CustomerID = Guid.NewGuid();
            exCustomer3.FirstName = "Bruce";
            exCustomer3.Surname = "Banner";
            Customers.Add(exCustomer3);
        }
    }
}
