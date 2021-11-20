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
    public class AccountantController : Controller
    {
        private readonly IAccountantService accountantService;
        public AccountantController(IAccountantService accountantService)
        {
            this.accountantService = accountantService;
        }
        [ProducesResponseType(typeof(List<Accountant>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Accountant), StatusCodes.Status400BadRequest)]
        [Route("DeleteAccountant/{id}")]
        [HttpDelete]
        public bool DeleteAccountant(int id)
        {
            return accountantService.DeleteAccountant(id);
        }
        [ProducesResponseType(typeof(List<Accountant>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Accountant), StatusCodes.Status400BadRequest)]
        [Route("GetAccountant")]
        [HttpGet]
        public List<Accountant> GetAccountant()
        {
            return accountantService.GetAccountant();
        }
        [ProducesResponseType(typeof(List<Accountant>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Accountant), StatusCodes.Status400BadRequest)]
        [Route("InsertAccountant")]
        [HttpPost]
        public bool InsertAccountant([FromBody] Accountant accountant)
        {
            return accountantService.InsertAccountant(accountant);
        }
        [ProducesResponseType(typeof(List<Accountant>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Accountant), StatusCodes.Status400BadRequest)]
        [Route("UpdateAccountant")]
        [HttpPut]
        public bool UpdateAccountant([FromBody] Accountant accountant)
        {
            return accountantService.UpdateAccountant(accountant);
        }
        [ProducesResponseType(typeof(List<Accountant>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Accountant), StatusCodes.Status400BadRequest)]
        [Route("GetAccountantByEmail/{email}")]
        [HttpGet]
        public Accountant GetAccountantByEmail(string email)
        {
            return accountantService.GetAccountantByEmail(email);
        }

        [Route("uploadAccountantImage")]
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
                var fullPath = Path.Combine("C:\\Users\\lenovo\\AngualrNew-811\\moviesAngular\\src\\assets\\" +
                "images\\EmployeeImages", attachmentFileName);
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                Customer item = new Customer();
                item.Img = attachmentFileName;


                return item;
            }
            catch (Exception e)
            {
                return null;
            }
        }




    }
}
