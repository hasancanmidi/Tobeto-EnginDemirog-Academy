using Core.Entities;


namespace Entities.Concretes;

public class Brand:IEntity
{
    public int BrandId { get; set; }
    public string BrandName { get; set; }
}