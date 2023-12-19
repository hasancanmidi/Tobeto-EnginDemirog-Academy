using System.Linq.Expressions;
using Core.Entities;

namespace DataAccess.Abstract;

public interface IEntityRepository<T> where T: class,IEntity,new()
{
    List<T> GetAll(Expression<Func<T,bool>> filter=null); //Burası bizim filtreler yazabilmemizi sağlıyor
    T Get(Expression<Func<T,bool>> filter);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
}