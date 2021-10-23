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
    }
}
