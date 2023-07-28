using Microsoft.AspNetCore.Mvc;

namespace EauClairesSalon.Controllers
{
    public class StylistController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }
    }
}