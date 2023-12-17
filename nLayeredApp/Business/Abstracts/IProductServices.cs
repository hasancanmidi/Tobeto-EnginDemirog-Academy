using Business.Dtos.Request;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts;

public interface IProductServices
{
    Task<IPaginate<Product>> GetListAsync();
    Task<CreatedProductResponse> Add(CreateProductRequest createProductRequest);
}
//Response request pattern