using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Mvc_Projem.EntityLayer.Concrete;
using X.PagedList;
using X.PagedList.Extensions;

namespace Mvc_Projem.Areas.Admin.Controllers;
[Area("Admin")]
public class CategoryController : Controller
{
    private CategoryManager cm = new CategoryManager(new EfCategoryRepository());
    public IActionResult Index(int page=1)
    {
        var values = cm.GetListAll().ToPagedList(page, 3);
        return View(values);
    }

    [HttpGet]
    public IActionResult AddCategory()
    {
        return View();
    }
    [HttpPost]
    public IActionResult AddCategory(Category p)
    {
        CategoryValidator cv = new CategoryValidator();
        ValidationResult results = cv.Validate(p);
        if (results.IsValid)
        {
            p.CategoryStatus = true;
            cm.TAdd(p);
            return RedirectToAction("Index", "Category");
        }
        else
        {
            foreach (var item in results.Errors)
            {
                ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            }
        }
        return View();    
    }

    public IActionResult CategoryDelete(int id)
    {
        var value = cm.TGetById(id);
        cm.TDelete(value);
        return RedirectToAction("Index");
    }
}