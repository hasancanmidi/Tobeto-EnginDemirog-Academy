using Core.Entities;

namespace Entities.Concretes;

public class Color:IEntity
{
    public int ColorId { get; set; }
    public string ColorName { get; set; }
}