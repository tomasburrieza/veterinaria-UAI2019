using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UAIVeterinaria.Interfaces;
using UAIVeterinaria.Models;

namespace UAIVeterinaria.Data
{
    public class PetRepository : IRepository<Pet>
    {
        VetDbContext context = new VetDbContext();
        public void Delete(int id)
        {
            var pet = context.Pets.FirstOrDefault(r => r.Id == id);
            context.Pets.Remove(pet);
            context.SaveChanges();
        }

        public Pet GetById(int id)
        {
            var Pet = context.Pets.FirstOrDefault(r => r.Id == id);
            return Pet;
        }

        public void Insert(Pet entity)
        {
            context.Pets.Add(entity);
            context.SaveChanges();
        }

        public IEnumerable<Pet> List()
        {
            var Pets = context.Pets.ToList();
            foreach (var pet in Pets)
            {
                pet.Owner = context.Owners.FirstOrDefault(r => r.Id == pet.OwnerId);
            }
            return Pets;
        }

        public void Update(Pet entity)
        {
            throw new NotImplementedException();
        }
    }
}