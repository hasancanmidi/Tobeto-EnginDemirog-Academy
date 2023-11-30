using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo.Concrete;

public  class StarbucksCustomerManager:BaseCustomerManager
{
    private ICustomerCheckService _customerCheckService;

    public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
    {
        _customerCheckService = customerCheckService;
    }

    public override void Save(Customer customer)
    {
        CheckIfRealPersoun(customer);
        base.Save(customer);
    }

    private void CheckIfRealPersoun(Customer customer)
    {
    }
}