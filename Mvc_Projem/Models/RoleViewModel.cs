using System.ComponentModel.DataAnnotations;

namespace Mvc_Projem.Models;

public class RoleViewModel
{
    [Required(ErrorMessage = "Lütfen Rol Adı Giriniz!!!")]
    public string Name { get; set; }
}