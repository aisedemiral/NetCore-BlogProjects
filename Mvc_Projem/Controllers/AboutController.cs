using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Mvc_Projem.EntityLayer.Concrete;

namespace Mvc_Projem.Controllers;

public class AboutController : Controller
{ 
    AboutManager abm = new AboutManager(new EfAboutRepository());

    public IActionResult Index()
    {
        var values = abm.GetList();

        return View(values);
    }

    public PartialViewResult SocialMediaAbout()
    {
        return PartialView();
    }
}