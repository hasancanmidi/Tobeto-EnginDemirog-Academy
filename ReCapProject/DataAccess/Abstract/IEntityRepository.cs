using System.Linq.Expressions;
using Entities.Abstract;
using Entities.Concretes;

namespace DataAccess.Abstract;

public interface IEntityRepository<T> where T: class,IEntity,new()
{
    public void GetById(Expression<Func<Car, bool>> filter = null);
    public void GetAll();
    public void Add();
    public void Update();
    public void Delete();
}