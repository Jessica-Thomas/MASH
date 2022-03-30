using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        return View();
    }

    public string chooseRandom(List<string>? spouses, List<string>? jobs, List<string>? pets, List<string>? transpos, List<string>? houses)
    {

        var randSpouse = spouses.OrderBy(s => Guid.NewGuid()).First();
        var randJob = jobs.OrderBy(j => Guid.NewGuid()).First();
        var randPet = pets.OrderBy(j => Guid.NewGuid()).First();
        var randTranspo = transpos.OrderBy(j => Guid.NewGuid()).First();
        var randHouse = houses.OrderBy(j => Guid.NewGuid()).First();


        //var rnd = new Random();
        //int spouse = rnd.Next(spouses.Count);
        //int job = rnd.Next(jobs.Count);
        //int pet = rnd.Next(pets.Count);
        //int transpo = rnd.Next(transpos.Count);
        //int house = rnd.Next(houses.Count);

        var destinyModel = new DestinyModel();

        return randSpouse;
        return randJob;
        return randPet;
        return randTranspo;
        return randHouse;
    }



}

