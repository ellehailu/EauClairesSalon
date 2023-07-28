using Microsoft.AspNetCore.Mvc;
using EauClairesSalon.Models;
using System.Linq;
using System.Collections.Generic;

namespace EauClairesSalon.Controllers
{
    public class ClientController : Controller
    {

        private readonly EauClairesSalonContext _db;

        public ClientController(EauClairesSalonContext db)
        {
            _db = db;
        }
        public ActionResult Index()
        {
            List<Client> model = _db.Clients.ToList();
            return View(model);
        }
    }
}