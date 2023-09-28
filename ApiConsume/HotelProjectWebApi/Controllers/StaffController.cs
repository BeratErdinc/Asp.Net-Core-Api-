using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
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
        public IActionResult AddStaff(Staff staff)
        {
            _staffservice.TInsert(staff);
            return Ok();
            

        }
        [HttpDelete]
        public IActionResult DeleteStaff(int id)
        {
            var values = _staffservice.TGetById(id);
            return Ok(values);

        }
        [HttpPut]
        public IActionResult UpdateStaff(Staff staff)
        {
            _staffservice.TUpdate(staff);
            return Ok();

        }
        [HttpGet("{id}")]
        public IActionResult GetStaff(int id)
        {
            var values = _staffservice.TGetById(id);

            return Ok(values);

        }
    }
}
