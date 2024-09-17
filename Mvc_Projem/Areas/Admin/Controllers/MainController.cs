using Microsoft.AspNetCore.Mvc;

namespace Mvc_Projem.Areas.Admin.Controllers;

public class MainController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}