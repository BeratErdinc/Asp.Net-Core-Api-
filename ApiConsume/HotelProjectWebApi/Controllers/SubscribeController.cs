using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        private readonly ISubscribeService _Subscribeservice;
        public SubscribeController(ISubscribeService Subscribeservice)
        {
            _Subscribeservice = Subscribeservice;
        }

        [HttpGet]
        public IActionResult SubscribeLis()
        {
            var values = _Subscribeservice.TGetList();
            return Ok(values);

        }
        [HttpPost]
        public IActionResult AddSubscribe(Subscribe Subscribe)
        {
            _Subscribeservice.TInsert(Subscribe);
            return Ok();


        }
        [HttpDelete]
        public IActionResult DeleteSubscribe(int id)
        {
            var values = _Subscribeservice.TGetById(id);
            return Ok(values);

        }
        [HttpPut]
        public IActionResult UpdateSubscribe(Subscribe Subscribe)
        {
            _Subscribeservice.TUpdate(Subscribe);
            return Ok();

        }
        [HttpGet("{id}")]
        public IActionResult GetSubscribe(int id)
        {
            var values = _Subscribeservice.TGetById(id);

            return Ok(values);

        }
    }
}
