using Microsoft.AspNetCore.Mvc;

namespace Mvc_Projem.Controllers;

public class DefaultController : Controller
{
    // GET
    public PartialViewResult Partial1()
    {
        return PartialView();
    }
}

