using InterfaceAbstractDemo.Entities;
namespace InterfaceAbstractDemo.Abstract;

public interface ICustomerCheckService
{
    void CheckIfRealPersoun(Customer customer);
}