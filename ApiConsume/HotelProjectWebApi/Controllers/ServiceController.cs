using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;
        public ServiceController(IServiceService ServiceService)
        {
            this._serviceService = ServiceService;
        }

        [HttpGet]
        public IActionResult ServiceLis()
        {
            var values = _serviceService.TGetList();
            return Ok(values);

        }
        [HttpPost]
        public IActionResult AddService(Service ro)
        {
            _serviceService.TInsert(ro);
            return Ok();

        }
        [HttpDelete]
        public IActionResult DeleteService(int id)
        {
            var values = _serviceService.TGetById(id);
            return Ok();

        }
        [HttpPut]
        public IActionResult UpdateService(Service sv)
        {
            _serviceService.TUpdate(sv);
            return Ok();

        }
        [HttpGet("{id}")]
        public IActionResult GetService(int id)
        {
            var values = _serviceService.TGetById(id);
            return Ok(values);

        }
    }
}
