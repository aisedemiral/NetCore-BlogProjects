using System.Text;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Mvc_Projem.Controllers;

public class EmployeeTestController : Controller
{
    // GET
    public async Task<IActionResult> Index()
    {
        var httpClient = new HttpClient();
        var responseMessage = await httpClient.GetAsync("http://localhost:5003/api/Default");
        var jsonString = await responseMessage.Content.ReadAsStringAsync();
        var values = JsonConvert.DeserializeObject<List<Class1>>(jsonString);
        return View(values);
    }
    [HttpGet]
    public IActionResult AddEmployee()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> AddEmployee(Class1 p)
    {
        var httpClient = new HttpClient();
        var jsonEmployee = JsonConvert.SerializeObject(p);
        StringContent content = new StringContent(jsonEmployee,Encoding.UTF8,"application/json");
        var responseMessage = await httpClient.PostAsync("http://localhost:5003/api/Default", content);
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }

        return View(p);
    }
    [HttpGet]
    public async Task<IActionResult> EditEmployee(int id)
    {
        var httpClient = new HttpClient();
        var responseMessage = await httpClient.GetAsync("http://localhost:5003/api/Default"+id);
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonEmployee = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<Class1>(jsonEmployee);
            return View(values);
        }

        return RedirectToAction("Index");

    }

    [HttpPost]
    public async Task<IActionResult> EditEmployee(Class1 p)
    {
        var httpClient = new HttpClient();
        var jsonEmployee = JsonConvert.SerializeObject(p);
        var content = new StringContent(jsonEmployee,Encoding.UTF8,"application/json");
        var responseMessage = await httpClient.PutAsync("http://localhost:5003/api/Default", content);
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }

        return View(p);
    }

    public async Task<IActionResult> DeleteEmployee(int id)
    {
        var httpClient = new HttpClient();
        var responseMessage = await httpClient.DeleteAsync("http://localhost:5003/api/Default/" + id);
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }

        return View();
    }

    public class Class1
    {
        public int  ID { get; set; }
        public string Name { get; set; }
    }

    
}