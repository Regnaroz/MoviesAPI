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
    public class CheckInOutController : Controller
    {
        private readonly ICheckInOutService checkInOutService;
        public CheckInOutController(ICheckInOutService checkInOutService)
        {
            this.checkInOutService = checkInOutService;
        }
        [ProducesResponseType(typeof(List<CheckInOut>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CheckInOut), StatusCodes.Status400BadRequest)]
        [Route("DeleteCheckInOut/{id}")]
        [HttpDelete]
        public bool DeleteCheckInOut(int id)
        {
            return checkInOutService.DeleteCheckInOut(id);
        }
        [ProducesResponseType(typeof(List<CheckInOut>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CheckInOut), StatusCodes.Status400BadRequest)]
        [Route("GetCheckInOut")]
        [HttpGet]
        public List<CheckInOut> GetCheckInOut()
        {
            return checkInOutService.GetCheckInOut();
        }
        [ProducesResponseType(typeof(List<CheckInOut>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CheckInOut), StatusCodes.Status400BadRequest)]
        [Route("InsertCheckInOut")]
        [HttpPost]
        public bool InsertCheckInOut(CheckInOut checkInOut)
        {
            return checkInOutService.InsertCheckInOut(checkInOut);
        }
        [ProducesResponseType(typeof(List<CheckInOut>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CheckInOut), StatusCodes.Status400BadRequest)]
        [Route("UpdateCheckInOut")]
        [HttpPut]
        public bool UpdateCheckInOut(CheckInOut checkInOut)
        {
            return checkInOutService.UpdateCheckInOut(checkInOut);
        }
    }
}
