using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MASH.Models;

namespace MASH.Controllers;

public class HomeController : Controller
{

    //create lists for storing selections and inputs for random selection
    //List<string> HouseOptions = ["Mansion", "Apartment", "Shack", "House"];
    List<string> SpouseOptions = new List<string>();
    List<string> TransportOptions = new List<string>();
    List<string> JobOptions = new List<string>();
    List<string> PetOptions = new List<string>();


    string UserSpouse;
    string UserTransport;
    string UserPet;
    string UserCar;

    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

}

