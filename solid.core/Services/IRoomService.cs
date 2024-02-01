using Solid.core.Enentities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.core.Services
{
    public interface IRoomService
    {
        List<Room> GetRooms();
        Room GetById(int id);
        Task<Room> AddRoomAsync(Room room);
        Task<Room> UpdateRoomStatusAsync(int id);
        Task<Room> DeleteRoomAsync(int id);
    }
}
