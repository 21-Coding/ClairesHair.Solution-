using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Claire.Controllers
{
    public class ClientsController : Controller 
    {
        private readonly ClairesHairContext _db;

        public ClientsController(ClairesHairContext db)
        {
            _db = db; 
        }

        public ActionResult Index()
        {
            List<Client> model = _db.Clients.Include(clients => clients.Stylist).ToList();
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(Client client)
        {
            _db.Clients.Add(client);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "StylistName");
            return View();
        }

        public ActionResult Details(int id)
        {
            Client aClient = _db.Clients.FirstOrDefault(clients => clients.ClientId == id);
            return View(aClient);
        }

        public ActionResult Edit(int id)
        {
            var aClient = _db.Clients.FirstOrDefault(clients => clients.ClientId == id);
            ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "StylistName");
            return View(aClient);
        }
    }
}