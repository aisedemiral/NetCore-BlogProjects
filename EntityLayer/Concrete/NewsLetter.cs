using System.ComponentModel.DataAnnotations;

namespace Mvc_Projem.EntityLayer.Concrete;

public class NewsLetter
{
    [Key]
    public int MailID { get; set; }
    public string Mail { get; set; }
    public bool MailStatus { get; set; }
}

