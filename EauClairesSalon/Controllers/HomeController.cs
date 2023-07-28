using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EauClairesSalon.Models;

namespace EauClairesSalon.Controllers;

public class HomeController : Controller
{
    [HttpGet("/")]
    public ActionResult Index()
    {
        return View();
    }
}
