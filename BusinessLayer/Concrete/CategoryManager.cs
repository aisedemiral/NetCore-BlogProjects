using BusinessLayer.Abstarct;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Mvc_Projem.EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class CategoryManager:ICategoryService
{
    ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public void TAdd(Category t)
    {
        _categoryDal.Insert(t);
    }

    public void TDelete(Category t)
    {
        _categoryDal.Delete(t);
    }

    public void TUpdate(Category t)
    {
        _categoryDal.Update(t);
    }

    public List<Category> GetListAll()
    {
        return _categoryDal.GetListAll();
    }

    public Category TGetById(int id)
    {
        return _categoryDal.GetByID(id);
    }
    
}