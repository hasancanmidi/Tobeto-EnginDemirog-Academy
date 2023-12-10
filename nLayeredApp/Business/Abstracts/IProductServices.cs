using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts;

public interface IProductServices
{
    Task<IPaginate<Product>> GetListAsync();
    Task Add(Product product);
}