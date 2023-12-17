using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntitiyFramework;

public class EfOrderDal:EfEntityRepositoryBase<Order,NorthwindContext>,IOrderDal
{
    
}