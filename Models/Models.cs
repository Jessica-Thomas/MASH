using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MASH.Models;


public class PageModel
{
    public class Spouse 
    { 
        public string GoldSpouse { get; set; }
        public string SilverSpouse { get; set; }
        public string BronzeSpouse { get; set; }
        public string UserSpouse { get; set; }
    }

    public List<SelectListItem> SilverSpouse = new()
    {
        new SelectListItem { Value = "1", Text = "Meredith Palmer" },
        new SelectListItem { Value = "2", Text = "Dwight Schrute" },
        new SelectListItem { Value = "3", Text = "Jan Levinson" },
        new SelectListItem { Value = "4", Text = "Kevin Mallone" }
    };


    public List<SelectListItem> GoldSpouse = new()
    {
        new SelectListItem { Value = "1", Text = "Derek Morgan" },
        new SelectListItem { Value = "2", Text = "Spencer Reid" },
        new SelectListItem { Value = "3", Text = "Penelope Garcia" },
        new SelectListItem { Value = "4", Text = "Emily Prentiss" }
    };

    public List<SelectListItem> BronzeSpouse = new()
    {
        new SelectListItem { Value = "1", Text = "Cersei Lannister" },
        new SelectListItem { Value = "2", Text = "Gustavo Fring" },
        new SelectListItem { Value = "3", Text = "Hannibal Lector" },
        new SelectListItem { Value = "4", Text = "Toby Flenderson" }
    };

        ViewBag.GoldSpouse = GoldSpouse;
        ViewBag.SilverSpouse = SilverSpouse;
        ViewBag.BronzeSpouse = BronzeSpouse;
}
       

    



//public class Transportation
//{
//    public string GoldTranspo { get; set; }
//    public string SilverTranspo { get; set; }
//    public string BronzeTranspo { get; set; }
//    public string UserTranspo { get; set; }

//}

//public class Job
//{
//    public string GoldJob { get; set; }
//    public string SilverJob { get; set; }
//    public string BronzeJob { get; set; }
//    public string UserJob { get; set; }

//}

//public class Pet
//{
//    public string GoldPet { get; set; }
//    public string SilverPet { get; set; }
//    public string BronzePet { get; set; }
//    public string UserPet { get; set; }

//}



