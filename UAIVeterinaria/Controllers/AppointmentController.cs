using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UAIVeterinaria.Models;
using UAIVeterinaria.Data;

namespace UAIVeterinaria.Controllers
{
    public class AppointmentController : Controller
    {
        AppointmentRepository repoApo = new AppointmentRepository();
        PetRepository repoPet = new PetRepository();
        DoctorRepository repoDoc = new DoctorRepository();
        RoomRepository repoRoom = new RoomRepository();
        // GET: Appointment
        public ActionResult Index()
        {
            return View();
        }

        //GET: Create
        public ActionResult Create()
        {
            ViewBag.Rooms = repoRoom.List();
            ViewBag.Doctors = repoDoc.List();
            ViewBag.Pets = repoPet.List();
            return View();
        }

        [HttpPost]
        public ActionResult Create(Appointment appo)
        {
            repoApo.Insert(appo);
            return RedirectToAction("Index");
        }
    }
}