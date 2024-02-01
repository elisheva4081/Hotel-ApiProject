using Microsoft.EntityFrameworkCore;
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
    public class PersonRepository : IPersonRepository
    {
        private readonly DataContext _context;

        public PersonRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<Person> AddPersonAsync(Person person)
        {
            await _context.People.AddAsync(person);
            await _context.SaveChangesAsync();
            return person;
        }

        public async Task<Person> DeletePersonAsync(int id)
        {
            var p = _context.People.Find(id);
             _context.People.Remove(p);
            await _context.SaveChangesAsync();
            return p;
        }

        public Person GetById(int id)
        {
            Person p = _context.People.Find(id);
            return p;
        }

        public IEnumerable<Person> GetPersons()
        {
            return _context.People.ToList();//.Include(p=>p.RoomId);
        }

        public async Task<Person> UpdatePersonAsync(int id, string name)
        {
            var p = _context.People.Find(id);
            p.Name= name;
            await _context.SaveChangesAsync();
            return p;
        }
    }
}
