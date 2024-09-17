using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Mvc_Projem.Areas.Admin.ViewComponents.Statistic;

public class Statistic2:ViewComponent
{
     Context c = new Context();
     BlogManager bm = new BlogManager(new EfBlogRepository());
     public IViewComponentResult Invoke()
     {
        
       // ViewBag.v1 = c.GetList().Count();
        return View();
     }
}