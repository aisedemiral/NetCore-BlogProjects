using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Mvc_Projem.ViewComponents.Category;

public class CategoryList:ViewComponent
{
     CategoryManager cm = new CategoryManager(new EfCategoryRepository());

     public IViewComponentResult Invoke()
     {
         var values = cm.GetListAll();
         return View(values);
     }
}