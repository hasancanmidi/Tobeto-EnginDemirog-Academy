using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes;
//EF entity framework
public class EfProductDal:EfRepositoryBase<Product,Guid,NorthwindContext>,IProductDal
{
    public EfProductDal(NorthwindContext context) : base(context) //Constructor
    {
    }
}