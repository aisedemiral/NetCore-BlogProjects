using Mvc_Projem.EntityLayer.Concrete;

namespace BusinessLayer.Abstarct;

public interface ICommentService
{
    void CommentAdd(Comment comment);
    List<Comment> GetList(int id);
    List<Comment> GetCommentwithBlog();

}