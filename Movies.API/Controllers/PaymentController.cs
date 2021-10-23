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
    public class PaymentController : Controller
    {
        private readonly IPaymentService PaymentService;
        public PaymentController(IPaymentService PaymentService)
        {
            this.PaymentService = PaymentService;
        }
        [ProducesResponseType(typeof(List<Payment>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Payment), StatusCodes.Status400BadRequest)]
        [HttpGet]
        [Route("GetPayment")]//sub route
        public List<Payment> GetPayment()
        {
            return PaymentService.GetPayment();
        }
        [ProducesResponseType(typeof(List<Payment>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Payment), StatusCodes.Status400BadRequest)]
        [HttpPost]
        [Route("InsertPayment")]//sub route
        public bool InsertPayment([FromBody] Payment Payment)
        {
            return PaymentService.InsertPayment(Payment);
        }
        [ProducesResponseType(typeof(List<Payment>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Payment), StatusCodes.Status400BadRequest)]
        [HttpDelete]
        [Route("DeletePayment/{id}")]//sub route
        public bool DeletePayment(int id)
        {
            return PaymentService.DeletePayment(id);
        }
        [ProducesResponseType(typeof(List<Payment>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Payment), StatusCodes.Status400BadRequest)]
        [HttpPut]
        [Route("UpdatePayment")]//sub route
        public bool UpdatePayment([FromBody] Payment Payment)
        {
            return PaymentService.UpdatePayment(Payment);
        }
        [ProducesResponseType(typeof(List<Payment>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Payment), StatusCodes.Status400BadRequest)]
        [HttpGet]
        [Route("GetSumOfpayments")]//sub route
        public IEnumerable<double> SumOfpayments()
        {
            return PaymentService.SumOfpayments();

        }
    }
}
