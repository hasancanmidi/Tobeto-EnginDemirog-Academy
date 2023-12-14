using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class ProductManager : IProductService
{
    IProductDal _ProductDal;

    public ProductManager(IProductDal productDal)
    {
        _ProductDal = productDal;
    }


    public List<Product> GetAll()
    {
        //İş Kodları
        //Yetkisi varmı ?
        //Herşey geçtiyse ürünleri ver
        return _ProductDal.GetAll();
    }
}