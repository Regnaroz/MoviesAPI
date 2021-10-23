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
    public class ExpensesController : Controller
    {
        private readonly IExpensesService ExpensesService;
        public ExpensesController(IExpensesService ExpensesService)
        {
            this.ExpensesService = ExpensesService;
        }
        [ProducesResponseType(typeof(List<Expenses>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Expenses), StatusCodes.Status400BadRequest)]
        [HttpGet]
        [Route("GetExpenses")]//sub route
        public List<Expenses> GetExpenses()
        {
            return ExpensesService.GetExpenses();
        }
        [ProducesResponseType(typeof(List<Expenses>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Expenses), StatusCodes.Status400BadRequest)]
        [HttpPost]
        [Route("InsertExpenses")]//sub route
        public bool InsertExpenses([FromBody]Expenses Expense)
        {
            return ExpensesService.InsertExpenses(Expense);
        }
        [ProducesResponseType(typeof(List<Expenses>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Expenses), StatusCodes.Status400BadRequest)]
        [HttpDelete]
        [Route("DeleteExpenses/{id}")]//sub route
        public bool DeleteExpenses(int id)
        {
            return ExpensesService.DeleteExpenses(id);
        }
        [ProducesResponseType(typeof(List<Expenses>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Expenses), StatusCodes.Status400BadRequest)]
        [HttpPut]
        [Route("UpdateExpenses")]//sub route
        public bool UpdateExpenses([FromBody] Expenses Expense)
        {
            return ExpensesService.UpdateExpenses(Expense);
        }
        [ProducesResponseType(typeof(List<Expenses>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Expenses), StatusCodes.Status400BadRequest)]
        [HttpGet]
        [Route("SumOfExpenses")]//sub route
        public IEnumerable<double> SumOfExpenses()
        {
            return ExpensesService.SumOfExpenses();

        }
    }
}
