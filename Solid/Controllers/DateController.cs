using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Solid.API.Models;
using Solid.core;
using Solid.core.DTOs;
using Solid.core.Enentities;
using Solid.core.Services;
using Solid.service.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DateController : ControllerBase
    {
        private readonly IDateService _dateService;
        private readonly IMapper _mapper;
        public DateController(IDateService dateService,IMapper mapper)
        {
            _dateService = dateService;
            _mapper = mapper;
        }
        // GET: api/<DateController>
        [HttpGet]
        public IActionResult Get()
        {
            var list = _dateService.GetDates();
            var listDto = _mapper.Map<IEnumerable<DateDto>>(list);
            return Ok(listDto);
        }

        // GET api/<DateController>/5
        [HttpGet("{id}")]
        public IActionResult Get(DateTime date)
        {
            var dateTmp = _dateService.GetById(date);
            var dateDto=_mapper.Map<DateDto>(dateTmp);
            return Ok(dateDto);
        }

        // POST api/<DateController>
        [HttpPost]
        public async Task<Date> Post([FromBody] DatePostModel date)
        {
            var dateToAdd=new Date {TheDate=date.TheDate, Butcher=date.Butcher,NameGuide=date.NameGuide};
            
            return await _dateService.AddDateAsync(dateToAdd);
        }

        // PUT api/<DateController>/5
        [HttpPut("{id}")]
        public async Task<Date> Put( string name, Date date)
        {
            return await _dateService.UpdateDateAsync(name, date);
        }

        // DELETE api/<DateController>/5
        [HttpDelete("{id}")]
        public async Task<Date> Delet(DateTime date)
        {
            return await _dateService.DeleteDateAsync(date);
        }
    }
}








