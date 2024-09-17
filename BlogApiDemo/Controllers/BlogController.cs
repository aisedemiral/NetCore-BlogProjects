using Microsoft.AspNetCore.Mvc;

namespace BlogAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BlogController : Controller
{
    
    private readonly ILogger<BlogController> _logger;

    public BlogController(ILogger<BlogController> logger) 
    {
        _logger = logger;
    }

    [HttpGet("GetInterests")]
    public ActionResult GetInterests() 
    {
        _logger.LogInformation("GetInterests method called: ");
        return Ok("interests");
    }
}