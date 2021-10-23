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
    }
}
