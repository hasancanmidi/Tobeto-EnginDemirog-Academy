using Business.Abstracts;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class ProductManager:IProductService
{
    IProductDal _productDal;

    public ProductManager(IProductDal productDal)
    {
        _productDal = productDal;
    }
    
    public async Task<IPaginate<Product>> GetListAsync()
    {
        return await _productDal.GetListAsync();
    }

    public async Task Add(Product product)
    {
        await _productDal.AddAsync(product);
    }

}