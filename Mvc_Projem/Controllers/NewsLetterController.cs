using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mvc_Projem.EntityLayer.Concrete;

namespace Mvc_Projem.Controllers;
[AllowAnonymous]
public class NewsLetterController : Controller
{
    NewsLetterManeger nm = new NewsLetterManeger(new EfNewsLetterRepository());
   [HttpGet]
    public PartialViewResult SubscribeMail()
    {
        return PartialView();
    }
    [HttpPost]
    public IActionResult SubscribeMail(NewsLetter p)
    {
        p.MailStatus = true;
        nm.AddNewsLetter(p);
        return PartialView();
    }
}