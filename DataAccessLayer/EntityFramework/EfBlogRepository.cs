using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using Mvc_Projem.EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework;

public class EfBlogRepository:GenericRepository<Blog>,IBlogDal
{
    public List<Blog> GetListWithCategory()
    {
        using (var c = new Context())
        {
            return c.Blogs.Include(x => x.Category).ToList();
        }
    }

    public List<Blog> GetListWithCategoryByWriter(int id)
    {
        using (var c = new Context())
        {
            return c.Blogs.Include(x => x.Category).Where(x=>x.WriterID==id).ToList();
        }
    }
}