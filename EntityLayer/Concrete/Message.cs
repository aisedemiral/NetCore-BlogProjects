using System.ComponentModel.DataAnnotations;

namespace Mvc_Projem.EntityLayer.Concrete;

public class Message
{
    [Key]
    public int MessageID { get; set; }
    public string Sender { get; set; }
    public string Receiver { get; set; }
    public string Subject { get; set; }
    public string MessageDetails { get; set; }
    public DateTime MessageDate { get; set; }
    public bool MessageStatus { get; set; }
}