using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UAIVeterinaria.Data;
using UAIVeterinaria.Models;

namespace UAIVeterinaria.Controllers
{
    public class RoomController : Controller
    {
        RoomRepository repo = new RoomRepository();
        // GET: Room
        public ActionResult Index()
        {
            return View(repo.List());
        }

        //GET: Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Room room)
        {
            repo.Insert(room);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var room = repo.GetById(id);
            if (room == null)
            {
                return HttpNotFound();
            }
            return View(room);
        }

        [HttpPost]
        public ActionResult Edit(Room room)
        {
            repo.Update(room);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            repo.Delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var room = repo.GetById(id);
            if (room == null)
            {
                return HttpNotFound();
            }
            return View(room);
        }
    }
}