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
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService DepartmentService;
        public DepartmentController(IDepartmentService DepartmentService)
        {
            this.DepartmentService = DepartmentService;
        }
        [ProducesResponseType(typeof(List<Department>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Department), StatusCodes.Status400BadRequest)]
        [HttpGet]
        [Route("GetDepartment")]//sub route
        public List<Department> GetDepartment()
        {
            return DepartmentService.GetDepartment();
        }
        [ProducesResponseType(typeof(List<Department>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Department), StatusCodes.Status400BadRequest)]
        [HttpPost]
        [Route("InsertDepartment")]//sub route
        public bool InsertDepartment([FromBody] Department Department)
        {
            return DepartmentService.InsertDepartment(Department);
        }
        [ProducesResponseType(typeof(List<Department>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Department), StatusCodes.Status400BadRequest)]
        [HttpDelete]
        [Route("DeleteDepartment/{id}")]//sub route
        public bool DeleteDepartment(int id)
        {
            return DepartmentService.DeleteDepartment(id);
        }
        [ProducesResponseType(typeof(List<Department>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Department), StatusCodes.Status400BadRequest)]
        [HttpPut]
        [Route("UpdateDepartment")]//sub route
        public bool UpdateDepartment([FromBody] Department Department)
        {
            return DepartmentService.UpdateDepartment(Department);
        }
    }
}
