using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Mvc_Projem.Controllers;

public class CategoryController : Controller
{ 
    CategoryManager cm = new CategoryManager(new EfCategoryRepository());
    
    public IActionResult Index()
    {
        var values = cm.GetListAll();
        return View(values);
    }
}