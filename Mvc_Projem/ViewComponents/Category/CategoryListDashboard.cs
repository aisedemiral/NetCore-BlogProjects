using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Mvc_Projem.ViewComponents.Category;

public class CategoryListDashboard:ViewComponent
{
    CategoryManager cm = new CategoryManager(new EfCategoryRepository());

    public IViewComponentResult Invoke()
    {
        var values = cm.GetListAll();
        return View(values);
    }
}