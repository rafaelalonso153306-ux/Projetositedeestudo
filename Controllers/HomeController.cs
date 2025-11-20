using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Projetositedeestudo.Models;

namespace Projetositedeestudo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
        //vai corinthians
     
     //Vai Corinthians//
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
