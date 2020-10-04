using AccountManagement.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Models.Implementations
{
    public class Customer : ICustomer
    {
        public Guid CustomerID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
    }
}
