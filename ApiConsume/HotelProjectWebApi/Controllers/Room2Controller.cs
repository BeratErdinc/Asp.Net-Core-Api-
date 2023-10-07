using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.Dto.Layer.Dtos.RoomDtos;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Runtime.CompilerServices;

namespace HotelProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Room2Controller : ControllerBase
    {
        private readonly IRoomService _roomservice;
        private readonly IMapper _mapper;

        public Room2Controller(IRoomService room, IMapper map)
        {
            _roomservice= room;
            _mapper= map;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = _roomservice.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddRoom(AddRoomDto addRoomDto)
        {
            if(!ModelState.IsValid) 
            {
                return BadRequest();
            }
            var values = _mapper.Map<Room>(addRoomDto);
            _roomservice.TInsert(values);
            return Ok();
        }
    }
}
