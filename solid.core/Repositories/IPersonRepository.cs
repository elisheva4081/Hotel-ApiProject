using Solid.core.Enentities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.core.Repositories
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetPersons();
        Person GetById(int id);
        Task<Person> AddPersonAsync(Person person);
        Task<Person> UpdatePersonAsync(int id, string name);
        Task<Person> DeletePersonAsync(int id);
    }
}
