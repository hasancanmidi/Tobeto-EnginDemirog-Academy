using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory;

public class InMemoryProductDal:IProductDal
{
    private List<Product> _products;
    private IProductDal _productDalImplementation;

    public InMemoryProductDal()
    {
        //Oracle , Sql Server , Postgres , MongoDb
        _products = new List<Product>
        {
            new Product{ProductId =1, CategoryId = 1,ProductName = "Bardak", UnitsInStock = 15, UnitPrice = 15},
            new Product{ProductId =2, CategoryId = 1,ProductName = "Kamera", UnitsInStock = 3, UnitPrice = 500},
            new Product{ProductId =3, CategoryId = 2,ProductName = "Telefon", UnitsInStock = 2, UnitPrice = 1500},
            new Product{ProductId =4, CategoryId = 2,ProductName = "Klavye", UnitsInStock = 65, UnitPrice = 150},
            new Product{ProductId =5, CategoryId = 2,ProductName = "Fare", UnitsInStock = 1, UnitPrice = 85}
        };
    }
    public List<Product> GetAll()
    {
        return _products;
    }


    public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
    {
        throw new NotImplementedException();
    }

    public Product Get(Expression<Func<Product, bool>> filter)
    {
        throw new NotImplementedException();
    }

    public void Add(Product product)
    {
        _products.Add(product);
    }

    public void Update(Product product)
    {
        //Gönderdiğim ürün id'sine sahip olan ürün idsini bul
        Product productToUpdate = _products.SingleOrDefault(p=>p.ProductId == product.ProductId);
        productToUpdate.ProductName = product.ProductName;
        productToUpdate.CategoryId = product.CategoryId;
        productToUpdate.UnitPrice = product.UnitPrice;
        productToUpdate.UnitsInStock = product.UnitsInStock;
    }

    public void Delete(Product product)
    {
        Product productToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId);
        _products.Remove(productToDelete);
        // LINQ 
    }

    public List<Product> GetAllByCategory(int categoryId)
    {
        return _products.Where(p => p.CategoryId == categoryId).ToList();
        //Where olarak verdiğin şarttakileri getirir
    }


}