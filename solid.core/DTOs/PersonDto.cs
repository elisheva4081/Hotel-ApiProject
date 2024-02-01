using Solid.core.Enentities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.core.DTOs
{
    public class PersonDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NumPhone { get; set; }

        public DateTime DateTheDate { get; set; }
        public int RoomId { get; set; }
        //public Date Date { get; set; }

        //public Room Room { get; set; }
    }
}
