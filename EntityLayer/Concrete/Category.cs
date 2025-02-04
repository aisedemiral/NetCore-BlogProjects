using System.ComponentModel.DataAnnotations;

namespace Mvc_Projem.EntityLayer.Concrete;

public class Category
{
    [Key]
    public int  CategoryID { get; set; }
    public string CategoryName { get; set; }
    public string CategoryDescription { get; set; }
    public bool CategoryStatus { get; set; }

    public List<Blog> Blogs { get; set; }
}