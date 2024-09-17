using Microsoft.AspNetCore.Mvc;
using Mvc_Projem.Areas.Admin.Models;
using Mvc_Projem.EntityLayer.Concrete;

namespace Mvc_Projem.Areas.Admin.Controllers;

[Area("Admin")]
public class ChartController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult CategoryChart()
    {
        List<CategoryClass> list = new List<CategoryClass>();
        list.Add(new CategoryClass
        {
            CategoryName = "Teknoloji",
            CategoryCount = 10
        });
        list.Add(new CategoryClass
        {
            CategoryName = "Yazılım",
            CategoryCount = 14
        });
        list.Add(new CategoryClass
        {
            CategoryName = "Spor",
            CategoryCount = 5
        });
        return Json(new { jsonlist = list });
    }
}