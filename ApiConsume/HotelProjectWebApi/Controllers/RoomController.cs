using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;
        public RoomController(IRoomService roomService)
        {
           _roomService = roomService;
        }

        [HttpGet]
        public IActionResult RoomLis()
        {
            var values =    _roomService.TGetList();
            return Ok(values);

        }
        [HttpPost]
        public IActionResult AddRoom(Room ro)
        {
            _roomService.TInsert(ro);
            return Ok();

        }
        [HttpDelete]
        public IActionResult DeleteRoom(int id)
        {
            var values = _roomService.TGetById(id);
            return Ok();

        }
        [HttpPut]
        public IActionResult UpdateRoom(Room ro)
        {
            _roomService.TUpdate(ro);
            return Ok();

        }
        [HttpGet("{id}")]
        public IActionResult GetRoom(int id)
        {
            var values=_roomService.TGetById(id);
            return Ok(values);

        }
    }
}
