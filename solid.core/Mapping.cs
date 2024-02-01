using Microsoft.VisualBasic;
using Solid.core.DTOs;
using Solid.core.Enentities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.core
{
    public class Mapping
    {
        public DateDto MapToDateDto(Date date)
        {
            return new DateDto { TheDate = date.TheDate,Butcher = date.Butcher,NameGuide = date.NameGuide};
        }
        public PersonDto MapToPersonDto(Person person)
        {
            return new PersonDto { Id = person.Id, Name = person.Name, NumPhone = person.NumPhone, /*DateStart = person.DateStart, /* RoomId = person.RoomId */};
        }
        public RoomDto MapToRoomDto(Room room)
        {
            return new RoomDto { Id = room.Id, Status = room.Status, NumOfBeds = room.NumOfBeds };
        }
    }
}
