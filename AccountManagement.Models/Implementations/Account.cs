using AccountManagement.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Models.Implementations
{
    public class Account : IAccount
    {
        public Guid AccountID { get; set; }
        public Guid CustomerID { get; set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
    }
}
