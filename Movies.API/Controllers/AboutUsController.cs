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
    public class AboutUsController : Controller
    {
        private readonly IAboutUsService aboutUsService;
        public AboutUsController(IAboutUsService aboutUsService)
        {
            this.aboutUsService = aboutUsService;
        }
        [ProducesResponseType(typeof(List<AboutUs>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(AboutUs), StatusCodes.Status400BadRequest)]
        [HttpDelete]
        [Route("DeleteAboutUs/{id}")]
        public bool DeleteAboutUs(int id)
        {
            return aboutUsService.DeleteAboutUs(id);
        }
        [ProducesResponseType(typeof(List<AboutUs>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(AboutUs), StatusCodes.Status400BadRequest)]
        [HttpGet]
        [Route("GetAboutUs")]
        public List<AboutUs> GetAboutUs()
        {
            return aboutUsService.GetAboutUs();
        }
        [ProducesResponseType(typeof(List<AboutUs>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(AboutUs), StatusCodes.Status400BadRequest)]
        [HttpPost]
        [Route("InsertAboutUs")]
        public bool InsertAboutUs([FromBody]AboutUs aboutUs)
        {
            return aboutUsService.InsertAboutUs(aboutUs);
        }
        [ProducesResponseType(typeof(List<AboutUs>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(AboutUs), StatusCodes.Status400BadRequest)]
        [HttpPut]
        [Route("UpdateCourse")]
        public bool UpdateCourse([FromBody] AboutUs aboutUs)
        {
            return aboutUsService.UpdateCourse(aboutUs);
        }
    }
}
