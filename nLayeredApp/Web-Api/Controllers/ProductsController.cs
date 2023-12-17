using Business.Abstracts;
using Business.Dtos.Request;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductServices _productService;

        public ProductsController(IProductServices productService)
        {
            _productService = productService;
        }

        [HttpPost] public async Task<IActionResult> Add([FromBody] CreateProductRequest createProductRequest) 

        { 
            var result = await _productService.Add(createProductRequest); 
            return Ok(result); 
        }

        [HttpGet] public async Task<IActionResult> GetList() 

        { 
            var result = await _productService.GetListAsync(); 
            return Ok(result); 
        }


    }
}