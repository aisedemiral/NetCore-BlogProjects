using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Mvc_Projem.Areas.Admin.Models;
using System.Collections.Generic;

namespace Mvc_Projem.Areas.Admin.Controllers;
[Area("Admin")]
public class WriterController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult WriterList()
    {
        var jsonWriters = JsonConvert.SerializeObject(writers);
        return Json(jsonWriters);
    }

    public IActionResult GetWriterById(int writerid)
    {
        var findWriter = writers.FirstOrDefault(x => x.Id == writerid);
        var jsonWriters = JsonConvert.SerializeObject(findWriter);
        return Json(jsonWriters);
    }

    [HttpPost]
    public IActionResult AddWriter(WriterClass w)
    {
        writers.Add(w);
        var jsonwriters = JsonConvert.SerializeObject(w);
        return Json(jsonwriters);
    }

    public IActionResult DeleteWriter(int id)
    {
        var writer = writers.FirstOrDefault(x => x.Id == id);
        writers.Remove(writer);
        return Json(writer);
    }

    public IActionResult UpdateWriter(WriterClass w)
    {
        var writer = writers.FirstOrDefault(x => x.Id == w.Id);
        writer.Name = w.Name;
        var jsonWriter = JsonConvert.SerializeObject(w);
        return Json(jsonWriter);
    }
    
    public static List<WriterClass> writers = new List<WriterClass>
    {
        new WriterClass
        {
            Id = 1,
            Name = "Aişe"
        },
        new WriterClass
        {
            Id = 2,
            Name = "Emre"
        },
        new WriterClass
        {
            Id = 2,
            Name = "Melike"
        }
    };
}