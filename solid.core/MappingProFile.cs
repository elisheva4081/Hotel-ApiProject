using AutoMapper;
using Solid.core.DTOs;
using Solid.core.Enentities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.core
{
    public class MappingProFile:Profile
    {
        public MappingProFile()
        {
            CreateMap<Date, DateDto>().ReverseMap();
            CreateMap<Person, PersonDto>().ReverseMap();
            CreateMap<Room, RoomDto>().ReverseMap();
        }

    }
}
