using System.ComponentModel.DataAnnotations;

namespace Mvc_Projem.Models;

public class UserSignUpViewModel
{
    [Display(Name = "Ad Soyad")]
    [Required(ErrorMessage = "Lütfen Şifre Giriniz!!")]
    public string NameSurname { get; set; } 
    
    [Display(Name = "Şifre")]
    [Required(ErrorMessage = "Lütfen Şifre Giriniz!!")]
    public string Password { get; set; } 
    
    [Display(Name = "Şifre Tekrar")]
    [Compare("Password",ErrorMessage = "Lütfen Şifrenizi Tekrar Giriniz!!")]
    public string ConfirmPassword { get; set; } 
    
    [Display(Name = "Mail Adresi")]
    [Required(ErrorMessage = "Lütfen Mailinizi Giriniz!!")]
    public string Mail { get; set; } 
    
    [Display(Name = "Kullanıcı Adı")]
    [Required(ErrorMessage = "Lütfen Kullanıcı Adınızı Giriniz!!")]
    public string UserName { get; set; } 
}