using Solid.core.Enentities;
using Solid.core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Solid.data.Repository
{
    internal class PersonRepository : IPersonRepository
    {
        private readonly DataContext _context;

        public PersonRepository(DataContext context)
        {
            _context = context;
        }
        public void AddPerson(Person person)
        {
            _context.People.Add(person);   
        }

        public void DeletePerson(int id)
        {
            var p = _context.People.Find(d => d.Id == id);
            _context.People.Remove(p);
        }

        public Person GetById(int id)
        {
            var p = _context.People.Find(d => d.Id == id);
            return p;
        }

        public List<Person> GetPersons()
        {
            return _context.People;
        }

        public void UpdatePerson(int id, Person person)
        {
            var p = _context.People.Find(d => d.Id == id);
            p= person;
        }
    }
}
