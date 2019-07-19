using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using UAIVeterinaria.Models;

namespace UAIVeterinaria.Data
{
    public class VetDbContext : DbContext
    {
        public VetDbContext() : base("DefaultConnection")
        {
        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
    }
}