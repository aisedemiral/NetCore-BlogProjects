using BusinessLayer.Abstarct;
using DataAccessLayer.Abstract;
using Mvc_Projem.EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class CommentManager:ICommentService
{ 
    ICommentDal _commentDal;

    public CommentManager(ICommentDal commentDal)
    {
        _commentDal = commentDal;
    }

    public void CommentAdd(Comment comment)
    {
        _commentDal.Insert(comment);
    }

    public List<Comment> GetList(int id)
    {
       return _commentDal.GetListAll(x => x.BlogID == id);
    }

    public List<Comment> GetCommentwithBlog()
    {
      return  _commentDal.GetListWithBlog();
    }
}