using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntitiyFramework;
//Context : Db tabloları ile proje classlarını bağlamak
public class NorthwindContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=localhost;Database=Northwind;User Id=SA; Password=reallyStrongPwd123; TrustServerCertificate=True;");
    }
    //Burası projen hangi veritabanıyla ilişkiliyi belirttiğin yer(conconfiguring)
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Customer> Customers { get; set; }
}