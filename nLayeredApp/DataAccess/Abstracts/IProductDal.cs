using Core.DataAccess.Repositories;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace DataAccess.Abstracts;

public interface IProductDal:IRepository<Product,Guid>,IAsyncRepository<Product,Guid>
{
    
}