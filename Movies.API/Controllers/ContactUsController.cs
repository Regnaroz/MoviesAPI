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
    public class ContactUsController : Controller
    {
        private readonly IContactUsService ContactUsService;
        public ContactUsController(IContactUsService ContactUsService)
        {
            this.ContactUsService = ContactUsService;
        }
        [ProducesResponseType(typeof(List<ContactUs>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ContactUs), StatusCodes.Status400BadRequest)]
        [HttpGet]
        [Route("GetContactUs")]//sub route
        public List<ContactUs> GetContactUs()
        {
            return ContactUsService.GetContactUs();
        }
        [ProducesResponseType(typeof(List<ContactUs>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ContactUs), StatusCodes.Status400BadRequest)]
        [HttpPost]
        [Route("InsertContactUs")]//sub route
        public bool InsertContactUs([FromBody] ContactUs ContactUs)
        {
            return ContactUsService.InsertContactUs(ContactUs);
        }
        [ProducesResponseType(typeof(List<ContactUs>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ContactUs), StatusCodes.Status400BadRequest)]
        [HttpDelete]
        [Route("DeleteContactUs/{id}")]//sub route
        public bool DeleteContactUs(int id)
        {
            return ContactUsService.DeleteContactUs(id);
        }
        [ProducesResponseType(typeof(List<ContactUs>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ContactUs), StatusCodes.Status400BadRequest)]
        [HttpPut]
        [Route("UpdateContactUs")]//sub route
        public bool UpdateContactUs([FromBody] ContactUs ContactUs)
        {
            return ContactUsService.UpdateContactUs(ContactUs);
        }
    }
}
