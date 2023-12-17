using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntitiyFramework;

public class EfProductDal:IProductDal
{
    //NuGet

    public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
    {
        using (NorthwindContext context = new NorthwindContext())
        {
            return filter == null
                ? context.Set<Product>().ToList()
                : context.Set<Product>().Where(filter).ToList(); //Arkaplanda select * from product döndürüyor
        }
    }

    public Product Get(Expression<Func<Product, bool>> filter)
    {
        using (NorthwindContext context = new NorthwindContext())
        {
            return context.Set<Product>().SingleOrDefault(filter);
        }
    }

    public void Add(Product entity)
    {
        //IDısposable pattern implementation of c# 
        using (NorthwindContext context = new NorthwindContext() )
        {
            var addedEntity = context.Entry(entity); //Referansı yakala
            addedEntity.State = EntityState.Added; //Eklenecek nesne
            context.SaveChanges(); //Eklendi
        }
    }

    public void Update(Product entity)
    {
        //IDısposable pattern implementation of c# 
        using (NorthwindContext context = new NorthwindContext() )
        {
            var updatedEntity = context.Entry(entity); //Referansı yakala
            updatedEntity.State = EntityState.Modified; //Eklenecek nesne
            context.SaveChanges(); //Eklendi
        }
    }

    public void Delete(Product entity)
    {
        using (NorthwindContext context = new NorthwindContext() )
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