using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.core.Enentities
{
    public class Room
    {
        public int Id { get; set; }
        public int NumOfBeds { get; set; }
        public bool Status { get; set; }

        public Room(int idRoom, int numOfBeds, bool isfilled)
        {
            Id = idRoom;
            NumOfBeds = numOfBeds;
            Status = isfilled;
        }
    }
}
