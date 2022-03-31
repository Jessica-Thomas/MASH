using Microsoft.AspNetCore.Mvc;
using MASH.Models;

namespace MASH.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        var PageModel = new PageModel();
        return View(PageModel);
    }

}
