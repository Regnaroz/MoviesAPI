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
    public class HistoryController : Controller
    {
        private readonly IHistoryService HistoryService;
        public HistoryController(IHistoryService HistoryService)
        {
            this.HistoryService = HistoryService;
        }
        [ProducesResponseType(typeof(List<History>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(History), StatusCodes.Status400BadRequest)]
        [HttpGet]
        [Route("GetHistory")]//sub route
        public List<History> GetHistory()
        {
            return HistoryService.GetHistory();
        }
        [ProducesResponseType(typeof(List<History>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(History), StatusCodes.Status400BadRequest)]
        [HttpPost]
        [Route("InsertHistory")]//sub route
        public bool InsertHistory([FromBody] History Histo)
        {
            return HistoryService.InsertHistory(Histo);
        }
        [ProducesResponseType(typeof(List<History>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(History), StatusCodes.Status400BadRequest)]
        [HttpDelete]
        [Route("DeleteHistory/{id}")]//sub route
        public bool DeleteHistory(int id)
        {
            return HistoryService.DeleteHistory(id);
        }
        [ProducesResponseType(typeof(List<History>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(History), StatusCodes.Status400BadRequest)]
        [HttpPut]
        [Route("UpdateHistory")]//sub route
        public bool UpdateHistory([FromBody] History Histo)
        {
            return HistoryService.UpdateHistory(Histo);
        }
        [ProducesResponseType(typeof(List<History>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(History), StatusCodes.Status400BadRequest)]
        [HttpPost]
        [Route("GetHistoryByCustomerId/{customerId}")]//sub route
        public List<History> GetHistoryByCustomerId(int customerId)
        {
            return HistoryService.GetHistoryByCustomerId(customerId);
        }
    }
}
