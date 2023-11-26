using Entities.Concretes;

namespace DataAccess.Concretes;

public class AdoNetCategoryDal
{
    public void Add(Category category)
    {
        Console.WriteLine("Ado.Net ile veritabanı bağlandı.");
    }
}