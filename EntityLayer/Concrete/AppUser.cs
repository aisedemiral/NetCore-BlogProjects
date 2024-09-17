using Microsoft.AspNetCore.Identity;

namespace Mvc_Projem.EntityLayer.Concrete;

public class AppUser : IdentityUser<int> 
{
    public string NameSurname { get; set; }
    public string? ImageUrl { get; set; }
}