﻿using Solid.core.Enentities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.core.Services
{
    public interface IPersonService
    {
        List<Person> GetPersons();
        Person GetById(int id);
        void AddPerson(Person person);
        void UpdatePerson(int id, Person person);
        void DeletePerson(int id);
    }
}