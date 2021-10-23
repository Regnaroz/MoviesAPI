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
    public class WorkingHoursController : Controller
    {
        private readonly IWorkingHoursService WorkingHoursService;
        public WorkingHoursController(IWorkingHoursService WorkingHoursService)
        {
            this.WorkingHoursService = WorkingHoursService;
        }
        [ProducesResponseType(typeof(List<WorkingHours>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(WorkingHours), StatusCodes.Status400BadRequest)]
        [HttpGet]
        [Route("GetWorkingHours")]//sub route
        public List<WorkingHours> GetWorkingHours()
        {
            return WorkingHoursService.GetWorkingHours();
        }
        [ProducesResponseType(typeof(List<WorkingHours>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(WorkingHours), StatusCodes.Status400BadRequest)]
        [HttpPost]
        [Route("InsertWorkingHours")]//sub route
        public bool InsertWorkingHours([FromBody] WorkingHours WorkingHours)
        {
            return WorkingHoursService.InsertWorkingHours(WorkingHours);
        }
        [ProducesResponseType(typeof(List<WorkingHours>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(WorkingHours), StatusCodes.Status400BadRequest)]
        [HttpDelete]
        [Route("DeleteWorkingHours/{id}")]//sub route
        public bool DeleteWorkingHours(int id)
        {
            return WorkingHoursService.DeleteWorkingHours(id);
        }
        [ProducesResponseType(typeof(List<WorkingHours>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(WorkingHours), StatusCodes.Status400BadRequest)]
        [HttpPut]
        [Route("UpdateWorkingHours")]//sub route
        public bool UpdateWorkingHours([FromBody] WorkingHours WorkingHours)
        {
            return WorkingHoursService.UpdateWorkingHours(WorkingHours);
        }
    }
}
