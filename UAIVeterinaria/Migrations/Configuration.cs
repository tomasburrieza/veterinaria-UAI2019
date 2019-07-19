namespace UAIVeterinaria.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using UAIVeterinaria.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<UAIVeterinaria.Data.VetDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(UAIVeterinaria.Data.VetDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            DateTime fechaHoy = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, 0, 0);
            for (int i = 0; i < 10; i++)
            {
                Appointment appointment = new Appointment();
                appointment.PetId = 0;
                appointment.RoomId = 0;
                appointment.DoctorId = 0;
                appointment.DateTime = fechaHoy.AddHours(i);
                context.Appointments.Add(appointment);
            }
            context.SaveChanges();
        }
    }
}
