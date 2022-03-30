using MASH.Models;
using Microsoft.AspNetCore.Mvc;


namespace MASH.Controllers;


public class ResultsController : Controller
{

    [HttpPost]
    public IActionResult Index(ResultsModel vm)
    {

        List<string>? spouses = new List<string>() { vm.GoldSpouse, vm.SilverSpouse, vm.BronzeSpouse, vm.UserSpouse };
        List<string>? jobs = new List<string>() { vm.GoldJob, vm.SilverJob, vm.BronzeJob, vm.UserJob };
        List<string>? pets = new List<string>() { vm.GoldPet, vm.SilverPet, vm.BronzePet, vm.UserPet };
        List<string>? transpos = new List<string>() { vm.GoldTranspo, vm.SilverTranspo, vm.BronzeTranspo, vm.UserTranspo };
        List<string>? houses = new List<string>() { "House", "Shack", "Apartment", "Mansion" };

        return View();
    }


    /*    public IActionResult chooseRandom(List<string>? spouses, List<string>? jobs, List<string>? pets, List<string>? transpos, List<string>? houses, DestinyModel destinyModel)
        {

            string? randSpouse = spouses.OrderBy(s => Guid.NewGuid()).First();
            string? randJob = jobs.OrderBy(j => Guid.NewGuid()).First();
            string? randPet = pets.OrderBy(p => Guid.NewGuid()).First();
            string? randTranspo = transpos.OrderBy(t => Guid.NewGuid()).First();
            string? randHouse = houses.OrderBy(h => Guid.NewGuid()).First();

            return ();
        }*/
    [HttpGet]
    public IActionResult chooseRandom(List<string>? spouses, List<string>? jobs, List<string>? pets, List<string>? transpos, List<string>? houses)
    {

        string? randSpouse = spouses.OrderBy(s => Guid.NewGuid()).First();
        string? randJob = jobs.OrderBy(j => Guid.NewGuid()).First();
        string? randPet = pets.OrderBy(p => Guid.NewGuid()).First();
        string? randTranspo = transpos.OrderBy(t => Guid.NewGuid()).First();
        string? randHouse = houses.OrderBy(h => Guid.NewGuid()).First();

        chooseHouse(houses);
        chooseJob(jobs);
        choosePet(pets);
        chooseTranspo(transpos);
        chooseSpouse(spouses);


        var destinyModel = new DestinyModel();
        return View(destinyModel);

    }

    private static string chooseHouse(List<string>? houses)
    {
        string? randHouse = houses.OrderBy(h => Guid.NewGuid()).First();
        return (randHouse);
    }

    private static string chooseTranspo(List<string>? transpos)
    {
        string? randTranspo = transpos.OrderBy(t => Guid.NewGuid()).First();
        return (randTranspo);
    }

    private static string choosePet(List<string>? pets)
    {
        string? randPet = pets.OrderBy(p => Guid.NewGuid()).First();
        return (randPet);
    }

    private static string chooseJob(List<string>? jobs)
    {
        string? randJob = jobs.OrderBy(j => Guid.NewGuid()).First();
        return (randJob);
    }

    private static string chooseSpouse(List<string>? spouses)
    {
        string? randSpouse = spouses.OrderBy(s => Guid.NewGuid()).First();
        return (randSpouse);
    }

}

