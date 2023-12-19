using System.Linq.Expressions;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Abstract.EntityFramework;

public class EfEntityRepositoryBase<TEntity, TContext>:IEntityRepository<TEntity>
    where TEntity : class, IEntity, new()
    where TContext : DbContext,new()
{
    public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
    {
        using (TContext context = new TContext())
        {
            return filter == null
                ? context.Set<TEntity>().ToList()
                : context.Set<TEntity>().Where(filter).ToList(); //Arkaplanda select * from product döndürüyor
        }
    }
    
    public TEntity Get(Expression<Func<TEntity, bool>> filter)
    {
        using (TContext context = new TContext())
        {
            return context.Set<TEntity>().SingleOrDefault(filter);
        }
    }
    
    public void Add(TEntity entity)
    {
        //IDısposable pattern implementation of c# 
        using (TContext context = new TContext() )
        {
            var addedEntity = context.Entry(entity); //Referansı yakala
            addedEntity.State = EntityState.Added; //Eklenecek nesne
            context.SaveChanges(); //Eklendi
        }
    }
    
    public void Update(TEntity entity)
    {
        //IDısposable pattern implementation of c# 
        using (TContext context = new TContext() )
        {
            var updatedEntity = context.Entry(entity); //Referansı yakala
            updatedEntity.State = EntityState.Modified; //Eklenecek nesne
            context.SaveChanges(); //Eklendi
        }
    }
    
    public void Delete(TEntity entity)
    {
        using (TContext context = new TContext() )
        {
            var deletedEntity = context.Entry(entity); //Referansı yakala
            deletedEntity.State = EntityState.Deleted; //silinecek nesne
            context.SaveChanges(); //Silindi
        }
    }
}
