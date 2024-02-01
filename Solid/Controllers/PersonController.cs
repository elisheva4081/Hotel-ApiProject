using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Solid.API.Models;
using Solid.core;
using Solid.core.DTOs;
using Solid.core.Enentities;
using Solid.core.Repositories;
using Solid.core.Services;
using Solid.service.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;
        private readonly IMapper _mapper;
        public PersonController(IPersonService personService, IMapper mapper)
        {
            _personService = personService;
            _mapper=mapper;
        }
        // GET: api/<PersonController>
        [HttpGet]
        public IActionResult Get()
        {
            var list = _personService.GetPersons();
            var listDto = _mapper.Map<IEnumerable<PersonDto>>(list);
            return Ok(listDto);
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var person = _personService.GetById(id);
            var personDto=_mapper.Map<PersonDto>(person);
            return Ok(personDto);
        }
       
        [HttpPost]
        public async Task<Person> Post([FromBody] PersonPostModel person)
        {
            var personToAdd=new Person { Name=person.Name ,NumPhone=person.NumPhone/*,Date=person.Date*/,DateTheDate=person.DateTheDate,RoomId=person.RoomId};
            return await _personService.AddPersonAsync(personToAdd);
            
        }

        // PUT api/<PersonController>/5
        [HttpPut("{id}")]
        public async Task<Person> Put(int id, string name)
        {
            return await _personService.UpdatePersonAsync(id, name);
        }

        // DELETE api/<PersonController>/5
        [HttpDelete("{id}")]
        public async Task<Person> Delete(int id)
        {
            return await _personService.DeletePersonAsync(id);
        }

    }
}







