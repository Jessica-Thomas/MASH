using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MASH.Models;

namespace MASH.Controllers;

public class HomeController : Controller
{

    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {

        var PageModel = new PageModel();
        return View(PageModel);
    }



}

