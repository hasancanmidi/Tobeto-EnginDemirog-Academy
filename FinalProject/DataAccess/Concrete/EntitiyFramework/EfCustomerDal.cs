using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntitiyFramework;

public class EfCustomerDal:ICustomerDal
{
    public List<Customer> GetAll(Expression<Func<Customer, bool>> filter = null)
    {
        throw new NotImplementedException();
    }

    public Customer Get(Expression<Func<Customer, bool>> filter)
    {
        throw new NotImplementedException();
    }

    public void Add(Customer entity)
    {
        throw new NotImplementedException();
    }

    public void Update(Customer entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Customer entity)
    {
        throw new NotImplementedException();
    }
}