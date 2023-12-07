using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace DataAccess.Concretes;

public class EfProductDal:EfRepositoryBase<Product,int,NortwindContext>,IProductDal
{
    
}