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
            // Establecemos una fecha para iniciar el seed de los horarios disponibles por veterinarie, sala y mascota.
            DateTime todayDateToSeed = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, 0, 0);
            for (int i = 0; i < 10; i++)
            {
                Appointment appointment = new Appointment();
                appointment.DoctorId = 0;
                appointment.RoomId = 0;
                appointment.PetId = 0;
                appointment.DateTime = todayDateToSeed.AddHours(i);
                context.Appointments.Add(appointment);
            }

            context.SaveChanges();
        }
    }
}
