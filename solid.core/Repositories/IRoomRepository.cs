using Solid.core.Enentities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.core.Repositories
{
    public interface IRoomRepository
    {
        List<Room> GetRooms();
        Room GetById(int id);
        Task<Room> AddRoomAsync(Room room);
        Task<Room> UpdateRoomStatusAsync(int id);
        Task<Room> DeleteRoomAsync(int id);
    }
}
