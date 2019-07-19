using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UAIVeterinaria.Models;
using UAIVeterinaria.Interfaces;

namespace UAIVeterinaria.Data
{
    public class DoctorRepository : IRepository<Doctor>
    {
        VetDbContext context = new VetDbContext();

        public void Insert(Doctor entity)
        {
            context.Doctors.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var Doctor = context.Doctors.FirstOrDefault(r => r.Id == id);
            context.Doctors.Remove(Doctor);
            context.SaveChanges();
        }

        public Doctor GetById(int id)
        {
            var Doctor = context.Doctors.FirstOrDefault(r => r.Id == id);
            return Doctor;
        }

        public IEnumerable<Doctor> List()
        {
            var Doctor = context.Doctors.ToList();
            return Doctor;
        }

        public void Update(Doctor entity)
        {
            context.Doctors.Attach(entity);
            context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
    }
}