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
    public class TasksController : Controller
    {
        private readonly ITasksService TasksService;
        public TasksController(ITasksService TasksService)
        {
            this.TasksService = TasksService;
        }
        [ProducesResponseType(typeof(List<Tasks>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Tasks), StatusCodes.Status400BadRequest)]
        [HttpGet]
        [Route("GetTasks")]//sub route
        public List<Tasks> GetTasks()
        {
            return TasksService.GetTasks();
        }
        [ProducesResponseType(typeof(List<Tasks>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Tasks), StatusCodes.Status400BadRequest)]
        [HttpPost]
        [Route("InsertTasks")]//sub route
        public bool InsertTasks([FromBody] Tasks Task)
        {
            return TasksService.InsertTasks(Task);
        }
        [ProducesResponseType(typeof(List<Tasks>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Tasks), StatusCodes.Status400BadRequest)]
        [HttpDelete]
        [Route("DeleteTasks/{id}")]//sub route
        public bool DeleteTasks(int id)
        {
            return TasksService.DeleteTasks(id);
        }
        [ProducesResponseType(typeof(List<Tasks>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Tasks), StatusCodes.Status400BadRequest)]
        [HttpPut]
        [Route("UpdateTasks")]//sub route
        public bool UpdateTasks([FromBody] Tasks Task)
        {
            return TasksService.UpdateTasks(Task);
        }
        [ProducesResponseType(typeof(List<Tasks>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Tasks), StatusCodes.Status400BadRequest)]
        [HttpPut]
        [Route("GetTasksByAccountantId/{accountantId}")]//sub route
        public List<Tasks> GetTasksByAccountantId(int accountantId)
        {
            return TasksService.GetTasksByAccountantId(accountantId);
        }
    }
}
