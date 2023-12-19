using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class CategoryManager : ICategoryService
{
    private ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }
    
    public List<Category> GetAll()
    {
        return _categoryDal.GetAll();
    }

    public Category GetById(int categoryId)
    {
        return _categoryDal.Get(c => c.CategoryId == categoryId);
        //Select * from Categories where CategoryId = 3
    }
}