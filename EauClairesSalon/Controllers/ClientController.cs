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

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Client client)
        {
            _db.Clients.Add(client);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            Client thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
            return View();
        }

        [HttpPost]
        public ActionResult Edit(Client client)
        {
            _db.Clients.Update(client);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}