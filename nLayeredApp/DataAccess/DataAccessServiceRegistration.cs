using DataAccess.Abstracts;
using DataAccess.Concretes;
using DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;


namespace DataAccess;

public static class DataAccessServiceRegistration
{
    public static IServiceCollection AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
    {
        //services.AddDbContext<NorthwindContext>(options=>options.UseInMemoryDatabase("nArchitecture"));
        services.AddDbContext<NorthwindContext>(options => options.UseSqlServer(configuration.GetConnectionString("ETradeC")));
        services.AddScoped<IProductDal, EfProductDal>();
        
        return services;
    }
}