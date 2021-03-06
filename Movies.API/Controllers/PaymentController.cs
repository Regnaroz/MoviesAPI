using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movies.Core.Data;
using Movies.Core.DTO;
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
        [ProducesResponseType(typeof(List<Payment>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Payment), StatusCodes.Status400BadRequest)]
        [HttpGet]
        [Route("IsUserOwnIt/{customerId}/{movieId}")]//sub route
        public bool IsUserOwnIt(int customerId, int movieId)
        {
            if (PaymentService.IsUserOwnIt(customerId, movieId)!=null)
            {
                return true;
            }
            return false;         
        }
        [ProducesResponseType(typeof(List<Payment>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Payment), StatusCodes.Status400BadRequest)]
        [HttpGet]
        [Route("GetTrending")]//sub route
        public List<trendingMovies> GetTrending()
        {
            return PaymentService.getTrendingMovies();
        }
        [ProducesResponseType(typeof(List<Payment>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Payment), StatusCodes.Status400BadRequest)]
        [HttpGet]
        [Route("getMonthlyGains")]//sub route
        public List<monthlyGains> GetMonthlyGains()
        {
            return PaymentService.getMonthlyGains();
        }
    }

 
}
