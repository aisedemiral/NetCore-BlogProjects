using Microsoft.AspNetCore.Mvc;

namespace Mvc_Projem.Controllers;

public class TestController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Test2()
    {
        return View();
    }
}