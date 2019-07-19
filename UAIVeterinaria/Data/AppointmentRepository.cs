using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UAIVeterinaria.Models;
using UAIVeterinaria.Interfaces;

namespace UAIVeterinaria.Data
{
    public class AppointmentRepository : IRepository<Appointment>
    {
        VetDbContext context = new VetDbContext();

        public void Insert(Appointment entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();

        }

        public Appointment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Appointment> List()
        {
            throw new NotImplementedException();
        }

        public void Update(Appointment entity)
        {
            throw new NotImplementedException();
        }
    }
}