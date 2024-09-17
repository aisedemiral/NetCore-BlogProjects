using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Mvc;
using Mvc_Projem.EntityLayer.Concrete;

namespace Mvc_Projem.Areas.Admin.Controllers;
[Area("Admin")]
public class AdminMessageController : Controller
{
     MessageManager mn = new MessageManager(new EfMessageRepository());
     Context c = new Context();
    public IActionResult Inbox()
    {
        return View();
    }

    public IActionResult SendBox()
    {
        return View();
    }

    public IActionResult ComposeMessage()
    {
        return View();
    }
}