using Movies.Core.Data;
using Movies.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Core.Repository
{
    public interface IPaymentRepository
    {
        public List<Payment> GetPayment();
        public bool InsertPayment(Payment Payment);
        public bool UpdatePayment(Payment Payment);
        public bool DeletePayment(int id);
        public List<trendingMovies> getTrendingMovies();
        public IEnumerable<double> SumOfpayments();
        public Payment IsUserOwnIt(int Id);

    }
}
