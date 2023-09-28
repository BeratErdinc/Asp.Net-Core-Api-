using HotelProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffservice;
        public StaffController(IStaffService staffservice)
        {
            _staffservice = staffservice;
        }

        [HttpGet]
        public IActionResult StaffLis()
        {
            var values = _staffservice.TGetList();
            return Ok (values);

        }
        [HttpPost]
        public IActionResult AddStaff()
        {
            return Ok();

        }
        [HttpDelete]
        public IActionResult DeleteStaff()
        {
            return Ok();

        }
        [HttpPut]
        public IActionResult UpdateStaff()
        {
            return Ok();

        }
        [HttpGet("{id}")]
        public IActionResult GetStaff()
        {
            return Ok();

        }
    }
}
