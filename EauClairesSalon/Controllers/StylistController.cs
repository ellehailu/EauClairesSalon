using Microsoft.AspNetCore.Mvc;
using EauClairesSalon.Models;
using System.Collections.Generic;
using System.Linq;

namespace EauClairesSalon.Controllers
{
    public class StylistController : Controller
    {

        private readonly EauClairesSalonContext _db;
        public StylistController(EauClairesSalonContext db)
        {
            _db = db;
        }
        public ActionResult Index()
        {
            List<Stylist> model = _db.Stylists.ToList();
            return View(model);
        }
    }
}