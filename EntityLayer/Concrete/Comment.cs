using System.ComponentModel.DataAnnotations;

namespace Mvc_Projem.EntityLayer.Concrete;

public class Comment
{
    [Key]
    public int CommentId { get; set; }
    public string CommentUserName { get; set; }
    public string CommentTitle { get; set; }
    public string CommentContent { get; set; }
    public DateTime CommentDate { get; set; }
    public bool CommentStatus { get; set; }
    public int BlogScore { get; set; }
    public int BlogID { get; set; }
    public Blog Blog { get; set; }
}