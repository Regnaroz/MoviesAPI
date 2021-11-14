using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movies.Core.Data;
using Movies.Core.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Movies.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerListController : Controller
    {
        private readonly ICustomerListService CustomerListService;
        public CustomerListController(ICustomerListService CustomerListService)
        {
            this.CustomerListService = CustomerListService;
        }
        [ProducesResponseType(typeof(List<CustomerList>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CustomerList), StatusCodes.Status400BadRequest)]
        [HttpGet]
        [Route("GetCustomerList")]//sub route
        public List<CustomerList> GetCustomerList()
        {
            return CustomerListService.GetCustomerList();
        }
        [ProducesResponseType(typeof(List<CustomerList>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CustomerList), StatusCodes.Status400BadRequest)]
        [HttpPost]
        [Route("InsertCustomerList")]//sub route
        public bool InsertCustomerList([FromBody] CustomerList CustomerList)
        {
            return CustomerListService.InsertCustomerList(CustomerList);
        }
        [ProducesResponseType(typeof(List<CustomerList>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CustomerList), StatusCodes.Status400BadRequest)]
        [HttpDelete]
        [Route("DeleteCustomerList/{id}")]//sub route
        public bool DeleteCustomerList(int id)
        {
            return CustomerListService.DeleteCustomerList(id);
        }
        [ProducesResponseType(typeof(List<CustomerList>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CustomerList), StatusCodes.Status400BadRequest)]
        [HttpPut]
        [Route("UpdateCustomerList")]//sub route
        public bool UpdateCustomerList([FromBody] CustomerList CustomerList)
        {
            return CustomerListService.UpdateCustomerList(CustomerList);
        }
        [ProducesResponseType(typeof(List<CustomerList>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CustomerList), StatusCodes.Status400BadRequest)]
        [HttpGet]
        [Route("IsInFavouraties/{customerId}/{movieId}")]
        public bool IsInFavouraties(int customerId, int movieId)
        {
            if (CustomerListService.IsInFavouraties(customerId, movieId) != null)
            {
                return true;
            }
            return false;
        }
        [ProducesResponseType(typeof(List<CustomerList>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CustomerList), StatusCodes.Status400BadRequest)]
        [HttpPost]
        [Route("Image")]
        public IActionResult Upload()
        {
            try
            {
                var file = Request.Form.Files[0];
                var folderName = Path.Combine("resc", "images");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
                if (file.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(folderName, fileName);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                    return Ok(new { dbPath });
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex} ");
            }
        }
    }
}
