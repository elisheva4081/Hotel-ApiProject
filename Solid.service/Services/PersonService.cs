using Solid.core.Enentities;
using Solid.core.Repositories;
using Solid.core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.service.Repository
{
    public class PersonService:IPersonService
    {
        private readonly IPersonRepository _personRepository;
        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        public async Task<Person> AddPersonAsync(Person person)
        {
            return await _personRepository.AddPersonAsync(person);
        }

        public async Task<Person> DeletePersonAsync(int id)
        {
            return await _personRepository.DeletePersonAsync(id);
        }

        public Person GetById(int id)
        {
            return _personRepository.GetById(id);
        }

        public IEnumerable<Person> GetPersons()
        {
            return _personRepository.GetPersons();
        }

        public async Task<Person> UpdatePersonAsync(int id, string name)
        {
            return await _personRepository.UpdatePersonAsync(id, name);
        }
    }
}
