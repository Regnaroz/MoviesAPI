using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movies.Core.Data;
using Movies.Core.Service;
using System;
using System.Collections.Generic;
using System.IO;
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
        [ProducesResponseType(typeof(List<Customer>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Customer), StatusCodes.Status400BadRequest)]
        [Route("uploadImage")]
        [HttpPost]
        public Customer UploadIMage()
        {
            try
            {
                var file = Request.Form.Files[0];
                byte[] fileContent;
                using (var ms = new MemoryStream())
                {
                    file.CopyTo(ms);
                    fileContent = ms.ToArray();
                }
                var fileName = Path.GetFileNameWithoutExtension(file.FileName);
                //decoder for image name , no duplicate errors
                string attachmentFileName = $"{fileName}.{Path.GetExtension(file.FileName).Replace(".", "")}";
                //path for angualr project file
                var fullPath = Path.Combine("C:\\Users\\Moayyad Alajlouni\\Desktop\\Angularmovies\\src\\assets\\images\\Uploaded File", attachmentFileName);
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                Customer item = new Customer();
                item.Img = attachmentFileName;
                return item;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}

