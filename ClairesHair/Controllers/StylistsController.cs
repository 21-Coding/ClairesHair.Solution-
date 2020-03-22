using Microsoft.AspNetCore.Mvc;
using Claire.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Claire.Controllers
{
    public class StylistsController : Controller
    {
        private readonly ClairesHairContext _db;

        public StylistsController(ClairesHairContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Stylist> model = _db.Stylists.ToList();
            return View(model);

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
            Stylist aStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id); aStylist.Clients = _db.Clients.Where(clients => clients.StylistId == id).ToList();
            return View(aStylist);

        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Edit(int id)
        {
            var aStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
            return View(aStylist);
        }
        [HttpPost]
        public ActionResult Edit(Stylist stylist)
        {
            _db.Entry(stylist).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var aStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
            return View(aStylist);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var aStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
            _db.Stylists.Remove(aStylist);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}