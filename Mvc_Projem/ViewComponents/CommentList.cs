using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Mvc_Projem.Models;

namespace Mvc_Projem.ViewComponents;

public class CommentList:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        var commentvalues = new List<UserComment>
        {
            new UserComment()
            {
                ID = 1,
                Username = "Mümine"
            },
            new UserComment()
            {
                ID = 2,
                Username = "Furkan"
            },
            new UserComment()
            {
            ID=3,
            Username="Oğuzhan",
            },
        };
        return View(commentvalues);
    }
}