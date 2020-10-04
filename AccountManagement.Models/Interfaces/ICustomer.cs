using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Models.Interfaces
{
    public interface ICustomer
    {
        Guid CustomerID { get; set; }
        string FirstName { get; set; }
        string Surname { get; set; }
    }
}
