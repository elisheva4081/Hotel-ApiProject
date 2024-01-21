using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.core.Enentities;

namespace Solid.data
{
    internal class DataContext
    {
        public List<Person> People { get; set; }
        public List<Room> Rooms { get; set; }
        public List<Date> Dates { get; set; }

        public DataContext()
        {
            People = new List<Person>();
            People.Add(new Person(326684081, "Elisheva", 0527104723, 1, new DateTime(2023, 11, 17)));
            People.Add(new Person(325746840, "Tehila", 0556737926, 2, new DateTime(2023, 11, 03)));
            People.Add(new Person(211474630, "Rachel", 0533104087, 3, new DateTime(2023, 9, 12)));

            Rooms = new List<Room>();
            Rooms.Add(new Room(1, 4, true));
            Rooms.Add(new Room(2, 4, true));
            Rooms.Add(new Room(3, 5, true));
            Rooms.Add(new Room(4, 2, false));

            Dates = new List<Date>();
            Dates.Add(new Date(new DateTime(5, 8, 2023), "Beni","Roni"));
            Dates.Add(new Date(new DateTime(21, 10, 2023), "Shimon","Yahir"));
            Dates.Add(new Date(new DateTime(18, 10, 2023), "David","Yoni"));
        }
    }
}
