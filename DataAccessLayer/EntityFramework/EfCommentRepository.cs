using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using Mvc_Projem.EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework;

public class EfCommentRepository:GenericRepository<Comment>,ICommentDal
{
    public List<Comment> GetListWithBlog()
    {
        using (var c = new Context())
        {
            return c.Comments.Include(x => x.Blog).ToList();
        }
        
    }
}