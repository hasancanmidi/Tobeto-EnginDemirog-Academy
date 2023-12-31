using Business.Abstracts;
using Business.Dtos.Request;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

//İş kurallarının yazıldıgı yer
public class ProductManager : IProductServices //interface
{
    IProductDal _productDal; //Dependence Injection - Dataccess çağrıyor

    public ProductManager(IProductDal productDal)
    {
        _productDal = productDal;
    }

    public async Task<IPaginate<Product>> GetListAsync()
    {
        return await _productDal.GetListAsync();
    }

    public async Task<CreatedProductResponse> Add(CreateProductRequest createProductRequest)
    {
        Product product = new Product();
        product.Id = Guid.NewGuid();
        product.ProductName = createProductRequest.ProductName;
        product.UnitPrice = createProductRequest.UnitPrice;
        product.QuantityPerUnit = createProductRequest.QuantityPerUnit;
        product.UnitsInStock = createProductRequest.UnitsInStock;
        Product createdProduct = await _productDal.AddAsync(product);

        CreatedProductResponse createdProductResponse = new CreatedProductResponse();
        createdProductResponse.Id = createdProduct.Id;
        createdProductResponse.ProductName = createdProduct.ProductName;
        createdProductResponse.UnitPrice = createdProduct.UnitPrice;
        createdProductResponse.QuantityPerUnit = createdProduct.QuantityPerUnit;
        createdProductResponse.UnitsInStock = createdProduct.UnitsInStock;
        return createdProductResponse;
    }
}