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
    public class CustomerController : Controller
    {
        private readonly ICustomerService customerService;
        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }
        [ProducesResponseType(typeof(List<Customer>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Customer), StatusCodes.Status400BadRequest)]
        [Route("DeleteCustomer/{id}")]
        [HttpDelete]
        public bool DeleteCustomer(int id)
        {
            return customerService.DeleteCustomer(id);
        }
        [ProducesResponseType(typeof(List<Customer>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Customer), StatusCodes.Status400BadRequest)]
        [Route("GetCustomer")]
        [HttpGet]
        public List<Customer> GetCustomer()
        {
            return customerService.GetCustomer();
        }
        [ProducesResponseType(typeof(List<Customer>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Customer), StatusCodes.Status400BadRequest)]
        [Route("GetCustomerByEmail/{email}")]
        [HttpGet]
        public Customer GetCustomerByEmail(string email)
        {
            return customerService.GetCustomerByEmail(email);
        }


        [ProducesResponseType(typeof(List<Customer>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Customer), StatusCodes.Status400BadRequest)]
        [Route("InsertCustomer")]
        [HttpPost]
        public bool InsertCustomer(Customer customer)
        {
             bool result = customerService.InsertCustomer(customer);
            if (result)
                return true;
            else
                return false;
        }
        [ProducesResponseType(typeof(List<Customer>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Customer), StatusCodes.Status400BadRequest)]
        [Route("UpdateCustomer")]
        [HttpPut]
        public bool UpdateCustomer(Customer customer)
        {
            return customerService.UpdateCustomer(customer);
        }
    }
}
