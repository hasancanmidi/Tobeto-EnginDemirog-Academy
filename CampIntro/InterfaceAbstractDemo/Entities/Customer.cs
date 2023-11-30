using InterfaceAbstractDemo.Abstract;
namespace InterfaceAbstractDemo.Entities;

public class Customer:IEntity
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string SurName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string NationalityId { get; set; }
}
