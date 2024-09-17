using Mvc_Projem.EntityLayer.Concrete;

namespace DataAccessLayer.Abstract;

public interface ICommentDal:IGenericDal<Comment>
{
    List<Comment> GetListWithBlog();
 
}