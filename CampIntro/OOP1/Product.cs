namespace OOP1;

public class Product //Entity
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public string ProductName { get; set; }
    public double UnitPrice { get; set; }
    public int UnitsInStock { get; set; }
    
    //CRUD İşlemleri Create Read Update Delete
}