using Microsoft.AspNetCore.Mvc;

namespace Mvc_Projem.Controllers;

public class ErrorPageController : Controller
{
    // GET
    public IActionResult Error1(int code)
    {
        return View();
    }
}