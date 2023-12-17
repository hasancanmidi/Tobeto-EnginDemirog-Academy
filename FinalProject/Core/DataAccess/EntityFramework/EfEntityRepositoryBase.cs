using System.Linq.Expressions;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.EntityFramework;

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


/*
 Kodun her bir satırını daha ayrıntılı olarak inceleyelim:

   *public void Add(Product entity): Bu satır, metodun genel bildirimini oluşturur.
   *Metodun adı Add'tir ve Product tipinde bir parametre alır.
   *IDısposable pattern implementation of c# : Bu satır, Entity Framework'ün IDisposable özelliğini nasıl uyguladığını açıklar.
   Entity Framework, veritabanı bağlantılarını ve diğer kaynakları yönetmek için IDisposable özelliğini kullanır.
   *using (NorthwindContext context = new NorthwindContext() ): Bu satır, bir NorthwindContext nesnesi oluşturur ve onu using bloğuna yerleştirir. using bloğu, nesnenin kullanımdan sonra otomatik olarak bırakılmasını sağlar.
   *var addedEntity = context.Entry(entity); //Referansı yakala : Bu satır, context.Entry(entity) yöntemini kullanarak, parametre olarak alınan Product nesnesine bir referans yakalar. Bu referans, nesnenin veritabanı ile ilişkisini temsil eder.
   *addedEntity.State = EntityState.Added; //Eklenecek nesne : Bu satır, addedEntity nesnesinin durumunu EntityState.Added olarak ayarlar. Bu, nesnenin veritabanına eklenecek olduğunu gösterir.
   *context.SaveChanges(); //Eklendi : Bu satır, context.SaveChanges() yöntemini kullanarak, nesneyi veritabanına kaydeder.


    *context.Set<Product>() yöntemi, veritabanındaki Product tablosuna erişim sağlar.
*/