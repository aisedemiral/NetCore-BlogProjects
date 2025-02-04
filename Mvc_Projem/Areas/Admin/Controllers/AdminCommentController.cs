using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Mvc_Projem.Areas.Admin.Controllers;
[Area("Admin")]
public class AdminCommentController : Controller
{ 
    CommentManager commentManager = new CommentManager(new EfCommentRepository());
    public IActionResult Index()
    {
        var values = commentManager.GetCommentwithBlog();
        return View(values);
    }
}