using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Models.Interfaces
{
    public interface IAccount
    {
        Guid AccountID { get; set; }
        Guid CustomerID { get; set; }
        string AccountNumber { get; set; }
        decimal Balance { get; set; }
    }
}
