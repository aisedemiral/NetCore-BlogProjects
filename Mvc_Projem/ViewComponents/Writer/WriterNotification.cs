using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Mvc_Projem.ViewComponents.Writer;

public class WriterNotification : ViewComponent
{
    NotificationManager nm = new NotificationManager(new EfNotificationRepository());

    public IViewComponentResult Invoke()
    {
            var values = nm.GetListAll();
            return View(values);
    }
}