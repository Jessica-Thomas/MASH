using Microsoft.AspNetCore.Mvc;
using MASH.Models;
using System.ComponentModel.DataAnnotations;

namespace MASH.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        var PageModel = new PageModel();
        return View(PageModel);
    }



}


//private readonly ILogger<HomeController> _logger;

//public HomeController(ILogger<HomeController> logger)
//{
//    _logger = logger;
//}