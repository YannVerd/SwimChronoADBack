using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProjectSwimChronoADBack.Models;

namespace ProjectSwimChronoADBack.Controllers;

public class TimesController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public TimesController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public void  GetOneTime(){
        TimesDBViewModel query = new();
        query.getOne();
        
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
