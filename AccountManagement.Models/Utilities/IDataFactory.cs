using AccountManagement.Models.Implementations;

namespace AccountManagement.Models.Utilities
{
    public interface IDataFactory
    {
        Account CreateAccount();
        Customer CreateCustomer();
        Transaction CreateTransaction();
    }
}