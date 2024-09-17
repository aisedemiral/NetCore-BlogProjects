using Mvc_Projem.EntityLayer.Concrete;

namespace DataAccessLayer.Abstract;

public interface IBlogDal:IGenericDal<Blog>
{
   List<Blog> GetListWithCategory();
   List<Blog> GetListWithCategoryByWriter(int id);
}