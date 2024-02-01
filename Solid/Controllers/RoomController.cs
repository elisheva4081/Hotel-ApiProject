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
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;
        public RoomController(IRoomService roomService, IMapper mapper)
        {
            _roomService = roomService;
            _mapper=mapper;
        }

        // GET: api/<RoomController>
        [HttpGet]
        public IActionResult Get()
        {
            var list = _roomService.GetRooms();
            var listDto=_mapper.Map<IEnumerable<RoomDto>>(list);
            return Ok(listDto);
        }

        // GET api/<RoomController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var room = _roomService.GetById(id);
            var roomDto=_mapper.Map<RoomDto>(room);
            return Ok(roomDto);
        }

        // POST api/<RoomController>
        [HttpPost]
        public async Task<Room> Post([FromBody] RoomPostModel room)
        {
            var roomToAdd=new Room { NumOfBeds=room.NumOfBeds,Status=room.Status};
            await _roomService.AddRoomAsync(roomToAdd);
            return roomToAdd;
        }

        // PUT api/<RoomController>/5
        [HttpPut("{id}")]
        public async Task<Room> Put(int id)
        {
            return await _roomService.UpdateRoomStatusAsync(id);
        }

        // DELETE api/<RoomController>/5
        [HttpDelete("{id}")]
        public async Task<Room> Delete(int id)
        {
             return await _roomService.DeleteRoomAsync(id);
        }
    }
}








