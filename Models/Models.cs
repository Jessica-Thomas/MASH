using Microsoft.AspNetCore.Mvc.Rendering;

namespace MASH.Models;


public class PageModel
{

    public List<SelectListItem> SilverSpouse = new List<SelectListItem>
    {
        new SelectListItem { Value = "1", Text = "Meredith Palmer" },
        new SelectListItem { Value = "2", Text = "Dwight Schrute" },
        new SelectListItem { Value = "3", Text = "Jan Levinson" },
        new SelectListItem { Value = "4", Text = "Kevin Mallone" }
    };
   }
       

    

//public class Spouse
//{
//    public string GoldSpouse { get; set; }
//    public string SilverSpouse { get; set; }
//    public string BronzeSpouse { get; set; }
//    public string UserSpouse { get; set; }
//}

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



