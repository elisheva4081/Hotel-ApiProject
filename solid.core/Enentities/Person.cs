using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.core.Enentities
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumPhone { get; set; }
        public int Idroom { get; set; }
        public DateTime TimeStart { get; set; }

        public Person(int id, string name, int numPhone, int idroom, DateTime timeStart)
        {
            Id = id;
            Name = name;
            NumPhone = numPhone;
            Idroom = idroom;
            TimeStart = timeStart;
        }
    }
}
