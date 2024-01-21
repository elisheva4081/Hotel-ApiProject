﻿using Solid.core.Enentities;
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
        void AddRoom(Room room);
        void UpdateRoom(int id, Room room);
        void DeleteRoom(int id);
    }
}