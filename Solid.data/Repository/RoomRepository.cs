using Solid.core.Enentities;
using Solid.core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Solid.data.Repository
{
    internal class RoomRepository : IRoomRepository
    {
        private readonly DataContext _context;

        public RoomRepository(DataContext context)
        {
            _context = context;
        }
        public void AddRoom(Room room)
        {
            _context.Rooms.Add(room);
        }

        public void DeleteRoom(int id)
        {
            var r = _context.Rooms.Find(d => d.Id == id);
            _context.Rooms.Remove(r);
        }

        public Room GetById(int id)
        {
            var r = _context.Rooms.Find(d => d.Id == id);
            return r;
        }

        public List<Room> GetRooms()
        {
            return _context.Rooms;      
        }

        public void UpdateRoom(int id, Room room)
        {
            var r = _context.Rooms.Find(d => d.Id == id);
            r = room;
        }
    }
}
