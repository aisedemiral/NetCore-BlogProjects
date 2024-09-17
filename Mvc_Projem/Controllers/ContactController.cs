using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mvc_Projem.EntityLayer.Concrete;

namespace Mvc_Projem.Controllers;
[AllowAnonymous]
public class ContactController : Controller
{
     ContactManager cm = new ContactManager(new EfContactRepository());
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(Contact p)
    {
        p.ContactDate=DateTime.Parse(DateTime.Now.ToShortDateString());
        p.ContactStatus = true;
        cm.ContactAdd(p);
        return RedirectToAction("Index","Contact");
    }
}