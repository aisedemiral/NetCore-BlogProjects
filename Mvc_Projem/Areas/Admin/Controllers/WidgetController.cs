using Microsoft.AspNetCore.Mvc;

namespace Mvc_Projem.Areas.Admin.Controllers;
[Area("Admin")]
public class WidgetController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}