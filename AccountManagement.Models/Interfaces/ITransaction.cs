using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Models.Interfaces
{
    public interface ITransaction
    {
        Guid TransactionID { get; set; }
        Guid AccountID { get; set; }
        DateTime TransactionDate { get; set; }
        decimal TransactionAmount { get; set; }
    }
}
