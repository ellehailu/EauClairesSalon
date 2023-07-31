using Microsoft.AspNetCore.Mvc;
using EauClairesSalon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Stylist stylist)
        {
            _db.Stylists.Add(stylist);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Stylist thisStylist = _db.Stylists.Include(stylist => stylist.Clients).FirstOrDefault(stylist => stylist.StylistId == id);
            return View(thisStylist);
        }

        public ActionResult Delete(int id)
        {
            Stylist thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
            return View(thisStylist);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult Deleted(int id)
        {
            Stylist thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
            _db.Stylists.Remove(thisStylist);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}