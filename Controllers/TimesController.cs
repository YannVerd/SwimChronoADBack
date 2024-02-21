using System.Diagnostics;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using ProjectSwimChronoADBack.Models;

namespace ProjectSwimChronoADBack.Controllers;

[Route("times")]
public class TimesController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public TimesController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public void  GetOneTime(){
        TimesDBViewModel query = new();
        query.GetOne();
        
    }

    [HttpPost]
    public void AddOneTime([FromBody]List<Object> list){
         // need to deserialize data from body  ?draw
         
        
        TimesDBViewModel query = new();
        query.AddOne(list);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
