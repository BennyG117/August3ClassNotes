//importing Frameworks:
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using August3ClassNotes.Models;

namespace August3ClassNotes.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

//!add  list of pets
    public static List<Pet> Pets = new List<Pet>();



    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

//! Add the httpGet below*
    //Index
    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

    //!Create
    [HttpPost("pet/create")]
    //add parameters
    public IActionResult Create(Pet newPet)
    {
        Pets.Add(newPet);
        return RedirectToAction("AllPets");
    }
    
    //!Get All Pets
    [HttpGet("allpets")]
    //Adding ", pets" as the list of pets
    public IActionResult AllPets()
    {
        return View("AllPets", Pets);
    }

    //Privacy - Not needed / can remove....
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
