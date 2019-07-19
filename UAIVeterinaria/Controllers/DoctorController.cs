using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UAIVeterinaria.Data;
using UAIVeterinaria.Models;

namespace UAIVeterinaria.Controllers
{
    public class DoctorController: Controller
    {
        DoctorRepository repo = new DoctorRepository();

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
        public ActionResult Create(Doctor doctor)
        {
            repo.Insert(doctor);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var doctor = repo.GetById(id);
            if (doctor == null)
            {
                return HttpNotFound();
            }
            return View(doctor);
        }

        [HttpPost]
        public ActionResult Edit(Doctor doctor)
        {
            repo.Update(doctor);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            repo.Delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var doctor = repo.GetById(id);
            if (doctor == null)
            {
                return HttpNotFound();
            }
            return View(doctor);
        }
    }
}