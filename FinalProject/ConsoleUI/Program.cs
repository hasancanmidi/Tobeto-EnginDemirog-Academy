using Business.Concrete;
using DataAccess.Concrete.EntitiyFramework;
using DataAccess.Concrete.InMemory;

//SOLID
//DTO Data Transformation Object

void ProductTest() 
{
    ProductManager productManager = new ProductManager(new EfProductDal()); //IoC'den sonra newlenmeyecek

    foreach (var product in productManager.getProductDetails())
    {
        Console.WriteLine(product.ProductName + " / " + product.CategoryName);
    }
}

void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal()); //IoC'den sonra newlenmeyecek
    {
        foreach (var category in categoryManager.GetAll())
        {
            Console.WriteLine(category.CategoryName);
        }
    }
}




ProductTest();
//CategoryTest();