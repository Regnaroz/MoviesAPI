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
    public class MessengerController : Controller
    {
        private readonly IMessengerService MessengerService;
        public MessengerController(IMessengerService MessengerService)
        {
            this.MessengerService = MessengerService;
        }
        [ProducesResponseType(typeof(List<Messenger>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Messenger), StatusCodes.Status400BadRequest)]
        [HttpGet]
        [Route("GetMessenger")]//sub route
        public List<Messenger> GetMessenger()
        {
            return MessengerService.GetMessenger();
        }
        [ProducesResponseType(typeof(List<Messenger>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Messenger), StatusCodes.Status400BadRequest)]
        [HttpPost]
        [Route("InsertMessenger")]//sub route
        public bool InsertMessenger([FromBody] Messenger Messenger)
        {
            return MessengerService.InsertMessenger(Messenger);
        }
        [ProducesResponseType(typeof(List<Messenger>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Messenger), StatusCodes.Status400BadRequest)]
        [HttpDelete]
        [Route("DeleteMessenger/{id}")]//sub route
        public bool DeleteMessenger(int id)
        {
            return MessengerService.DeleteMessenger(id);
        }
        [ProducesResponseType(typeof(List<Messenger>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Messenger), StatusCodes.Status400BadRequest)]
        [HttpPut]
        [Route("UpdateMessenger")]//sub route
        public bool UpdateMessenger([FromBody] Messenger Messenger)
        {
            return MessengerService.UpdateMessenger(Messenger);
        }
        [ProducesResponseType(typeof(List<Messenger>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Messenger), StatusCodes.Status400BadRequest)]
        [HttpPut]
        [Route("GetMessengerByCustomerId/{customerId}")]//sub route
        public List<Messenger> GetMessengerByCustomerId(int customerId)
        {
            return MessengerService.GetMessengerByCustomerId(customerId);
        }
    }
}
