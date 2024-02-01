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
    public class RoomRepository : IRoomRepository
    {
        private readonly DataContext _context;
        public RoomRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<Room> AddRoomAsync(Room room)
        {
            _context.Rooms.AddAsync(room);
            await _context.SaveChangesAsync();
            return room;
        }

        public async Task<Room> DeleteRoomAsync(int id)
        {
            var r = _context.Rooms.Find( id);
            _context.Rooms.Remove(r);
            await _context.SaveChangesAsync();
            return r;
        }

        public Room GetById(int id)
        {
            var r = _context.Rooms.Find( id);
            return r;
        }

        public List<Room> GetRooms()
        {
            return _context.Rooms.ToList();      
        }

        public async Task<Room> UpdateRoomStatusAsync(int id)
        {
            var r = _context.Rooms.Find(id);
            r.Status = !r.Status;
            await _context.SaveChangesAsync();
            return r;
        }
    }
}
