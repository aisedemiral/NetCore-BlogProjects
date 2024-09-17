using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Mvc_Projem.EntityLayer.Concrete;
using Mvc_Projem.Models;
using Mvc_Projem.Views.Writer;

namespace Mvc_Projem.Controllers;
public class WriterController : Controller
{
     WriterManager wm = new WriterManager(new EfWriterRepository());
     UserManager userManager = new UserManager(new EfUserRepository());
     private readonly UserManager<AppUser> _userManager;

     public WriterController(UserManager<AppUser> userManager)
     {
         _userManager = userManager;
     }

     public IActionResult Index()
     {
         var usermail = User.Identity.Name;
         ViewBag.v = usermail;
         Context c = new Context();
         var writerName = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterName).FirstOrDefault();
         ViewBag.v2 = writerName; 
        return View();
    }

    public IActionResult WriterMail()
    {
        return View();
    }
    [AllowAnonymous]
    public IActionResult Test()
    {
        return View();
    }
    [AllowAnonymous]
    public PartialViewResult WriterNavbarPartial()
    {
        return PartialView();
    }
    [AllowAnonymous]
    public PartialViewResult WriterFooterPartial()
    {
        return PartialView();
    }

    [HttpGet]
    public async Task<IActionResult> WriterEditProfile()
    {
      var values = await _userManager.FindByNameAsync(User.Identity.Name);
      UserUpdateViewModel model = new UserUpdateViewModel();
      model.Mail = values.Email;
      model.NameSurname = values.NameSurname;
      model.ImageUrl = values.ImageUrl;
      model.Username = values.UserName;
       return View(model);
    }
    [HttpPost]
    public async Task<IActionResult> WriterEditProfile(UserUpdateViewModel model)
    {
        var values = await _userManager.FindByNameAsync(User.Identity.Name);
        model = new UserUpdateViewModel();
        values.NameSurname = model.NameSurname;
        values.ImageUrl = model.ImageUrl;
        values.Email = model.Mail;
        values.PasswordHash = _userManager.PasswordHasher.HashPassword(values, model.password);
        var result = await _userManager.UpdateAsync(values);
        return RedirectToAction("Index","DashBoard");
    }

    [AllowAnonymous]
    [HttpGet]
    public IActionResult WriterAdd()
    {
        return View();
    }

    [AllowAnonymous]
    [HttpPost]
    public IActionResult WriterAdd(AddProfileImage p)
    {
        Writer w = new Writer();
        if (p.WriterImage != null)
        {
            var extension = Path.GetExtension(p.WriterImage.FileName);
            var newimagename = Guid.NewGuid() + extension;
            var location = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/WriterImageFiles/",newimagename);
            var stream = new FileStream(location, FileMode.Create);
            p.WriterImage.CopyTo(stream);
            w.WriterImage = newimagename;
        }

        w.WriterMail = p.WriterMail;
        w.WriterName = p.WriterName;
        w.WriterPassword = p.WriterPassword;
        w.WriterStatus = true;
        w.WriterAbout = p.WriterAbout;
        wm.TAdd(w);
        return RedirectToAction("Index", "DashBoard");
    }

}