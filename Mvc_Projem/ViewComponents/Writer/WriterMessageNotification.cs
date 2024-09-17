using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Mvc_Projem.EntityLayer.Concrete;

namespace Mvc_Projem.ViewComponents.Writer;

public class WriterMessageNotification:ViewComponent
{
    private MessageManager mn = new MessageManager(new EfMessageRepository());
    public IViewComponentResult Invoke()
    {
        string p;
        p = "mumineaise@gmail.com";
        var values = mn.GetInboxListByWriter(p);
        return View(values);
    }
}