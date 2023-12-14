
using System.Linq.Expressions;
using Entities.Abstract;

namespace DataAccess.Abstract;
//Generic Constraint > IEntitiyRepository<T> T Kısmına gelecek şeyleri filtrelememiz sadece veri tabanı nesnelerimiz gelmeli
//Class : referans tip
//IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir
//new() : new() koyuyoruz amacı newlenebilen'de olmasın çünkü T'ye IEntity koyabiliyoruz, koyamamamız lazım
public interface IEntitiyRepository<T> where T:class,IEntity,new() //T'ya IEntity olabilir yada ondan implement olan bir şey olabilir
{
    List<T> GetAll(Expression<Func<T,bool>> filter=null); //Burası bizim filtreler yazabilmemizi sağlıyor
    T Get(Expression<Func<T,bool>> filter);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);

}