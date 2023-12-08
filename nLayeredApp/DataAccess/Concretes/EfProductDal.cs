using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes;

public class EfProductDal:EfRepositoryBase<Product,int,NorthwindContext>,IProductDal
{
    public EfProductDal(NorthwindContext context) : base(context)
    {
    }
}