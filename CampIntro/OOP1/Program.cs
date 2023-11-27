using OOP1;

Product product1 = new Product();
product1.Id = 1;
product1.CategoryId = 2;
product1.ProductName = "Masa";
product1.UnitPrice = 500;
product1.UnitsInStock = 3;

Product product2 = new Product {Id = 2,CategoryId = 5,UnitsInStock = 5,ProductName = "Kalem",UnitPrice = 35};

//case sensitive
//PascalCase   //camelCase
ProductManager productManager = new ProductManager();
productManager.Add(product1);
Console.WriteLine(product1.ProductName);

// int, double,bool ... değer tip
// diziler,class,abstract class, interface... referans tip
// ref out (kodlamaio'da ödevmiş bakarsın.)

productManager.Topla2(3,6); //Void olduğu için devamını getiremiyoruz orada bitiyor
int toplamaSonucu = productManager.Topla(3, 6);
Console.WriteLine(toplamaSonucu*2);





















