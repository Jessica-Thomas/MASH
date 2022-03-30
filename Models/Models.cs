using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace MASH.Models;


public class PageModel
{

    public List<SelectListItem> GoldSpouseOptions = new()
    {
        new SelectListItem { Value = "Derek Morgan", Text = "Derek Morgan" },
        new SelectListItem { Value = "Spencer Reid", Text = "Spencer Reid" },
        new SelectListItem { Value = "Penelope Garcia", Text = "Penelope Garcia" },
        new SelectListItem { Value = "Emily Prentiss", Text = "Emily Prentiss" }
    };

    public List<SelectListItem> SilverSpouseOptions = new()
    {
        new SelectListItem { Value = "Meredith Palmer", Text = "Meredith Palmer" },
        new SelectListItem { Value = "Dwight Schrute", Text = "Dwight Schrute" },
        new SelectListItem { Value = "Jan Levinson", Text = "Jan Levinson" },
        new SelectListItem { Value = "Kevin Mallone", Text = "Kevin Mallone" }
    };

    public List<SelectListItem> BronzeSpouseOptions = new()
    {
        new SelectListItem { Value = "Cersei Lannister", Text = "Cersei Lannister" },
        new SelectListItem { Value = "Gustavo Fring", Text = "Gustavo Fring" },
        new SelectListItem { Value = "Hannibal Lector", Text = "Hannibal Lector" },
        new SelectListItem { Value = "Toby Flenderson", Text = "Toby Flenderson" }
    };

    public List<SelectListItem> GoldTranspoOptions = new()
    {
        new SelectListItem { Value = "Maserati", Text = "Maserati" },
        new SelectListItem { Value = "Aston Martin", Text = "Aston Martin" },
        new SelectListItem { Value = "Ferarri", Text = "Ferarri" },
        new SelectListItem { Value = "Lamborghini", Text = "Lamborghini" }
    };

    public List<SelectListItem> SilverTranspoOptions = new()
    {
        new SelectListItem { Value = "Toyota", Text = "Toyota" },
        new SelectListItem { Value = "Ford", Text = "Ford" },
        new SelectListItem { Value = "KIA", Text = "KIA" },
        new SelectListItem { Value = "Chevy", Text = "Chevy" }
    };

    public List<SelectListItem> BronzeTranspoOptions = new()
    {
        new SelectListItem { Value = "Razor Scooter", Text = "Razor Scooter" },
        new SelectListItem { Value = "Hanging Out The Side of Your Best Friend's Ride", Text = "Hanging Out The Side of Your Best Friend's Ride" },
        new SelectListItem { Value = "Rollerblades", Text = "Rollerblades" },
        new SelectListItem { Value = "City Bus", Text = "City Bus" }
    };

    public List<SelectListItem> GoldJobOptions = new()
    {
        new SelectListItem { Value = "Special Agent", Text = "Special Agent" },
        new SelectListItem { Value = "Mob Boss", Text = "Mob Boss" },
        new SelectListItem { Value = "Drug Lord", Text = "Drug Lord" },
        new SelectListItem { Value = "Music Mogul", Text = "Music Mogul" }
    };

    public List<SelectListItem> SilverJobOptions = new()
    {
        new SelectListItem { Value = "News Anchor", Text = "News Anchor" },
        new SelectListItem { Value = "Veterinarian", Text = "Veterinarian" },
        new SelectListItem { Value = "Software Developer", Text = "Software Developer" },
        new SelectListItem { Value = "Pilot", Text = "Pilot" }
    };

    public List<SelectListItem> BronzeJobOptions = new()
    {
        new SelectListItem { Value = "Assistant to the Regional Manager", Text = "Assistant to the Regional Manager" },
        new SelectListItem { Value = "Cashier", Text = "Cashier" },
        new SelectListItem { Value = "Circus Clown", Text = "Circus Clown" },
        new SelectListItem { Value = "Chimney Sweep", Text = "Chimney Sweep" }
    };

    public List<SelectListItem> GoldPetOptions = new()
    {
        new SelectListItem { Value = "Tiger", Text = "Tiger" },
        new SelectListItem { Value = "Bear", Text = "Bear" },
        new SelectListItem { Value = "Shark", Text = "Shark" },
        new SelectListItem { Value = "Velociraptor", Text = "Velociraptor" }
    };

    public List<SelectListItem> SilverPetOptions = new()
    {
        new SelectListItem { Value = "Lemur", Text = "Lemur" },
        new SelectListItem { Value = "The Pony I Never Got as a Child", Text = "The Pony I Never Got as a Child" },
        new SelectListItem { Value = "Sloth", Text = "Sloth" },
        new SelectListItem { Value = "Platypus", Text = "Platypus" }
    };

    public List<SelectListItem> BronzePetOptions = new()
    {
        new SelectListItem { Value = "Cat", Text = "Cat" },
        new SelectListItem { Value = "Dog", Text = "Dog" },
        new SelectListItem { Value = "Hamster", Text = "Hamster" },
        new SelectListItem { Value = "Fish", Text = "Fish" }
    };
}


public class ResultsModel
{

    public string? GoldSpouse { get; set; }
    public string? SilverSpouse { get; set; }
    public string? BronzeSpouse { get; set; }

    [Required]
    [RegularExpression("[a-zA-Z]+")]
    public string? UserSpouse { get; set; }


    public string? GoldTranspo { get; set; }
    public string? SilverTranspo { get; set; }
    public string? BronzeTranspo { get; set; }

    [Required]
    [RegularExpression("[a-zA-Z]+")]
    public string? UserTranspo { get; set; }


    public string? GoldJob { get; set; }
    public string? SilverJob { get; set; }
    public string? BronzeJob { get; set; }

    [Required]
    [RegularExpression("[a-zA-Z]+")]
    public string? UserJob { get; set; }

    public string? GoldPet { get; set; }
    public string? SilverPet { get; set; }
    public string? BronzePet { get; set; }
    [Required]
    [RegularExpression("[a-zA-Z]+")]
    public string? UserPet { get; set; }
}


public class DestinyModel
{
    public string? RandSpouse { get; set; }
    public string? RandJob { get; set; }
    public string? RandPet { get; set; }
    public string? RandTranspo { get; set; }
    public string? RandHouse { get; set; }
}