using Core.Entities;
namespace Entities.Concretes;

public class Category:Entity<int>
{

    public string Name { get; set; }
    public List<Product> ProductsType { get; set; }
}