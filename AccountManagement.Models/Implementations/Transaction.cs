using AccountManagement.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Models.Implementations
{
    public class Transaction : ITransaction
    {
        public Guid TransactionID { get; set; }
        public Guid AccountID { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal TransactionAmount { get; set; }
    }
}
