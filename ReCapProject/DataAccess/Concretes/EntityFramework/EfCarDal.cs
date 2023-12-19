using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework;

public class EfCarDal
{
    public void GetById(Expression<Func<Car, bool>> filter = null)
    {
        throw new NotImplementedException();
    }
    public void GetAll()
    {
        throw new NotImplementedException();
    }

    public void Add()
    {
        throw new NotImplementedException();
    }

    public void Update()
    {
        throw new NotImplementedException();
    }

    public void Delete()
    {
        throw new NotImplementedException();
    }
}