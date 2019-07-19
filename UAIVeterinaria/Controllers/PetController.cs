using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UAIVeterinaria.Data;
using UAIVeterinaria.Models;

namespace UAIVeterinaria.Controllers
{
    public class PetController : Controller
    {
        PetRepository repoPet = new PetRepository();
        OwnerRepository repoOwner = new OwnerRepository();

        // GET: Room
        public ActionResult Index()
        {
            return View(repoPet.List());
        }

        //GET: Create
        public ActionResult Create(int ownerId)
        {
            Pet pet = new Pet();
            pet.OwnerId = ownerId;
            pet.Owner = repoOwner.GetById(ownerId);
            return View(pet);
        }

        [HttpPost]
        public ActionResult Create(Pet pet)
        {
            repoPet.Insert(pet);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var Pet = repoPet.GetById(id);
            if (Pet == null)
            {
                return HttpNotFound();
            }
            return View(Pet);
        }

        [HttpPost]
        public ActionResult Edit(Pet Pet)
        {
            repoPet.Update(Pet);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            repoPet.Delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var Pet = repoPet.GetById(id);
            if (Pet == null)
            {
                return HttpNotFound();
            }
            return View(Pet);
        }
    }
}