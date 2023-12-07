using System.Reflection;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Contexts;

public class NorthwindContext : DbContext
{
    protected IConfiguration Configuration { get; set; }
    public DbSet<Product> Products { get; set; }

    public NorthwindContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
    {
        Configuration = configuration;
        Database.Ensur eCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Apply ConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}