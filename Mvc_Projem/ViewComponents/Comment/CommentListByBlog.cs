using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace Mvc_Projem.ViewComponents.Comment;

public class CommentListByBlog:ViewComponent
{
    private CommentManager cm = new CommentManager(new EfCommentRepository());
    public ViewViewComponentResult Invoke(int id)
    {
        var values = cm.GetList(id);
        return View(values);
    }
}