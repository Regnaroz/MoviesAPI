using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movies.Core.Data;
using Movies.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : Controller
    {
        private readonly ITestimonialService TestimonialService;
        public TestimonialController(ITestimonialService TestimonialService)
        {
            this.TestimonialService = TestimonialService;
        }
        [ProducesResponseType(typeof(List<Testimonial>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Testimonial), StatusCodes.Status400BadRequest)]
        [HttpGet]
        [Route("GetTestimonial")]//sub route
        public List<Testimonial> GetTestimonial()
        {
            return TestimonialService.GetTestimonial();
        }
        [ProducesResponseType(typeof(List<Testimonial>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Testimonial), StatusCodes.Status400BadRequest)]
        [HttpPost]
        [Route("InsertTestimonial")]//sub route
        public bool InsertTestimonial([FromBody] Testimonial Testimonial)
        {
            return TestimonialService.InsertTestimonial(Testimonial);
        }
        [ProducesResponseType(typeof(List<Testimonial>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Testimonial), StatusCodes.Status400BadRequest)]
        [HttpDelete]
        [Route("DeleteTestimonial/{id}")]//sub route
        public bool DeleteTestimonial(int id)
        {
            return TestimonialService.DeleteTestimonial(id);
        }
        [ProducesResponseType(typeof(List<Testimonial>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Testimonial), StatusCodes.Status400BadRequest)]
        [HttpPut]
        [Route("UpdateTestimonial")]//sub route
        public bool UpdateTestimonial([FromBody] Testimonial Testimonial)
        {
            return TestimonialService.UpdateTestimonial(Testimonial);
        }
        [ProducesResponseType(typeof(List<Testimonial>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Testimonial), StatusCodes.Status400BadRequest)]
        [HttpGet]
        [Route("GetActiveTestimonial")]//sub route
        public List<Testimonial> GetActiveTestimonial()
        {
            return TestimonialService.GetActiveTestimonial();
        }
    }
}
