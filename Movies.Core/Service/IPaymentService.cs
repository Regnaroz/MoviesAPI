using Movies.Core.Data;
using Movies.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Core.Service
{
   public interface IPaymentService
    {
        public List<Payment> GetPayment();
        public bool InsertPayment(Payment Payment);
        public bool UpdatePayment(Payment Payment);
        public List<trendingMovies> getTrendingMovies();
        public List<monthlyGains> getMonthlyGains();
        public bool DeletePayment(int id);
        public IEnumerable<double> SumOfpayments();
        public Payment IsUserOwnIt(int customerId, int movieId);

    }
}
