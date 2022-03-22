using Microsoft.AspNetCore.Mvc;
using MASH.Models;

namespace MASH.Controllers;

public class HomeController : Controller
{

    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, object petList)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {

        var PageModel = new PageModel();
        return View(PageModel);
    }


    [HttpPost]
    public IActionResult Submit(PageModel page)
    {
        var spouseList = new List<string>();
        {
            string? silverChoice = page.SilverSpouse;
            string? goldChoice = page.GoldSpouse;
            string? bronzeChoice = page.BronzeSpouse;
            string? userChoice = page.UserSpouse;
        };

        var jobList = new List<string>();
        {
            string? silverChoice = page.SilverJob;
            string? goldChoice = page.GoldJob;
            string? bronzeChoice = page.BronzeJob;
            string? userChoice = page.UserJob;
        };

        var transpoList = new List<string>();
        {
            string? silverChoice = page.SilverTranspo;
            string? goldChoice = page.GoldTranspo;
            string? bronzeChoice = page.BronzeTranspo;
            string? userChoice = page.UserTranspo;
        };

        var petList = new List<string>();
        {
            string? silverChoice = page.SilverPet;
            string? goldChoice = page.GoldPet;
            string? bronzeChoice = page.BronzePet;
            string? userChoice = page.UserPet;
        };

        return View(page);

    }


}

