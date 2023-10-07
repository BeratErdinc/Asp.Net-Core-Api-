using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialservice;
        public TestimonialController(ITestimonialService testimonialservice)
        {
            _testimonialservice = testimonialservice;
        }

        [HttpGet]
        public IActionResult testimonialLis()
        {
            var values = _testimonialservice.TGetList();
            return Ok(values);

        }
        [HttpPost]
        public IActionResult Addtestimonial(Testimonial testimonial)
        {
            _testimonialservice.TInsert(testimonial);
            return Ok();


        }
        [HttpDelete]
        public IActionResult Deletetestimonial(int id)
        {
            var values = _testimonialservice.TGetById(id);
             
            _testimonialservice.TDelete(values);
            return Ok(values);

        }
        [HttpPut]
        public IActionResult Updatetestimonial(Testimonial testimonial)
        {
            _testimonialservice.TUpdate(testimonial);
            return Ok();

        }
        [HttpGet("{id}")]
        public IActionResult Gettestimonial(int id)
        {
            var values = _testimonialservice.TGetById(id);

            return Ok(values);

        }
    }
}
