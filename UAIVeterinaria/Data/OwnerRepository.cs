using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UAIVeterinaria.Interfaces;
using UAIVeterinaria.Models;

namespace UAIVeterinaria.Data
{
    public class OwnerRepository : IRepository<Owner>
    {
        VetDbContext context = new VetDbContext();
        public void Delete(int id)
        {
            var owner = context.Owners.FirstOrDefault(r => r.Id == id);
            owner.Pets = context.Pets.Where(o => o.OwnerId == owner.Id).ToList();
            foreach (var pet in owner.Pets)
            {
                context.Pets.Remove(pet);
            }
            context.Owners.Remove(owner);
            context.SaveChanges();
        }

        public Owner GetById(int id)
        {
            var Owner = context.Owners.FirstOrDefault(r => r.Id == id);
            return Owner;
        }

        public void Insert(Owner entity)
        {
            context.Owners.Add(entity);
            context.SaveChanges();  
        }

        public IEnumerable<Owner> List()
        {
            var Owners = context.Owners.ToList();
            return Owners;
        }

        public void Update(Owner entity)
        {
            throw new NotImplementedException();
        }
    }
}