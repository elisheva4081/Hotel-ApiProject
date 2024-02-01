using Solid.core.Enentities;
using Solid.core.Repositories;
using Solid.core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.service.Repository
{
    public class RoomService:IRoomService
    {
        private readonly IRoomRepository _roomRepository;
        public RoomService(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }
        public async Task<Room> AddRoomAsync(Room room)
        {
            return await _roomRepository.AddRoomAsync(room);
        }

        public async Task<Room> DeleteRoomAsync(int id)
        {
            return await _roomRepository.DeleteRoomAsync(id);
        }

        public Room GetById(int id)
        {
            return _roomRepository.GetById(id);
        }

        public List<Room> GetRooms()
        {
            return _roomRepository.GetRooms();
        }

        public async Task<Room> UpdateRoomStatusAsync(int id)
        {
            return await _roomRepository.UpdateRoomStatusAsync(id);
        }
    }
}
