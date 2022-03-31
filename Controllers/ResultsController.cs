using Microsoft.AspNetCore.Mvc;
using MASH.Models;

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

        var destinyModel = new DestinyModel();

        destinyModel.RandHouse = ChooseHouse(houses);
        destinyModel.RandJob = ChooseJob(jobs);
        destinyModel.RandPet = ChoosePet(pets);
        destinyModel.RandTranspo = ChooseTranspo(transpos);
        destinyModel.RandSpouse = ChooseSpouse(spouses);


        return View(destinyModel);
    }


    public string ChooseHouse(List<string>? houses)
    {
        string? randHouse = houses.OrderBy(h => Guid.NewGuid()).First();
        return randHouse;
    }

    public string ChooseTranspo(List<string>? transpos)
    {
        string? randTranspo = transpos.OrderBy(t => Guid.NewGuid()).First();
        return randTranspo;
    }

    public string ChoosePet(List<string>? pets)
    {
        string? randPet = pets.OrderBy(p => Guid.NewGuid()).First();
        return randPet;
    }

    public string ChooseJob(List<string>? jobs)
    {
        string? randJob = jobs.OrderBy(j => Guid.NewGuid()).First();
        return randJob;
    }

    public string ChooseSpouse(List<string>? spouses)
    {
        string? randSpouse = spouses.OrderBy(s => Guid.NewGuid()).First();
        return randSpouse;
    }

}

