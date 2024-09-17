using System.ComponentModel.DataAnnotations;

namespace Mvc_Projem.Models;

public class UserSingInModel
{
    [Required(ErrorMessage = "Lütfen kullanıcı adını giriniz!!")]
    public string UserName { get; set; }
    [Required(ErrorMessage = "Lütfen şifrenizi giriniz!!")]
    public string Password { get; set; }
}