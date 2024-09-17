using Mvc_Projem.EntityLayer.Concrete;

namespace BusinessLayer.Abstarct;

public interface IBlogService:IGenericService<Blog>
{
    List<Blog> GetBlogListWithCategory();
    List<Blog> GetBlogListByWriter(int id);
}