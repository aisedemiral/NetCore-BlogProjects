using System.Security.Claims;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Mvc_Projem.EntityLayer.Concrete;
using Mvc_Projem.Models;

namespace Mvc_Projem.Controllers;

[AllowAnonymous]
public class LoginController : Controller
{
    private readonly SignInManager<AppUser> _signInManager;
    
    public LoginController(SignInManager<AppUser> signInManager)
    {
        _signInManager = signInManager;
    }
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Index(UserSingInModel p)
    {
        if (ModelState.IsValid)
        {
        var result = await _signInManager.PasswordSignInAsync(p.UserName, p.Password, false, true);
             if (result.Succeeded)
             {
                 return RedirectToAction("Index", "DashBoard");
             }
             else
             {
                 ModelState.AddModelError(string.Empty, "Giriş yapılamadı. Kullanıcı adı veya şifre yanlış.");
             }
        }

        return View();
    }

    public async Task<IActionResult> LogOut()
    {
        await _signInManager.SignOutAsync();
        return RedirectToAction("Index","Login");
    }

    public IActionResult AccessDenied()
    {
        return View();
    }
}
