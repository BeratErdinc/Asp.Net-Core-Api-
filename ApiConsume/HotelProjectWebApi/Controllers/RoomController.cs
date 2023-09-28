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
        private readonly IRoomService roomService;
        public RoomController(IRoomService roomService)
        {
            this.roomService = roomService;
        }

        [HttpGet]
        public IActionResult RoomLis()
        {
            var values = roomService.TGetList();
            return Ok(values);

        }
        [HttpPost]
        public IActionResult AddRoom(Room ro)
        {
            roomService.TInsert(ro);
            return Ok();

        }
        [HttpDelete]
        public IActionResult DeleteRoom(int id)
        {
            var values = roomService.TGetById(id);
            return Ok();

        }
        [HttpPut]
        public IActionResult UpdateRoom(Room ro)
        {
            roomService.TUpdate(ro);
            return Ok();

        }
        [HttpGet("{id}")]
        public IActionResult GetRoom(int id)
        {
            var values=roomService.TGetById(id);
            return Ok(values);

        }
    }
}
