using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Mvc_Projem.Controllers;

public class NotificationController : Controller
{
    private NotificationManager nm = new NotificationManager(new EfNotificationRepository());
    public IActionResult Index()
    {
        return View();
    }
    [AllowAnonymous]
    public IActionResult AllNotification()
    {
        var values = nm.GetListAll();
        return View(values);
    }
}