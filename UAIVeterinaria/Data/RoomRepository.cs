using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UAIVeterinaria.Models;
using UAIVeterinaria.Interfaces;

namespace UAIVeterinaria.Data
{
    public class RoomRepository : IRepository<Room>
    {
        VetDbContext context = new VetDbContext();

        public void Insert(Room entity)
        {
            context.Rooms.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var room = context.Rooms.FirstOrDefault(r => r.Id == id);
            context.Rooms.Remove(room);
            context.SaveChanges();
        }

        public Room GetById(int id)
        {
            var room = context.Rooms.FirstOrDefault(r => r.Id == id);
            return room;
        }

        public IEnumerable<Room> List()
        {
            var rooms = context.Rooms.ToList();
            return rooms;
        }

        public void Update(Room entity)
        {
            context.Rooms.Attach(entity);
            context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
    }
}