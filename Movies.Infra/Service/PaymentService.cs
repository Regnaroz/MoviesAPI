using Movies.Core.Data;
using Movies.Core.Repository;
using Movies.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Infra.Service
{
    public class PaymentService: IPaymentService
    {
        private readonly IPaymentRepository PaymentRepository;
        public PaymentService(IPaymentRepository PaymentRepository)
        {
            this.PaymentRepository = PaymentRepository;
        }

        public bool DeletePayment(int id)
        {
            return PaymentRepository.DeletePayment(id);
        }

        public List<Payment> GetPayment()
        {
            return PaymentRepository.GetPayment();
        }

        public bool InsertPayment(Payment Payment)
        {
            return PaymentRepository.InsertPayment(Payment);
        }

        public bool UpdatePayment(Payment Payment)
        {
            return PaymentRepository.UpdatePayment(Payment);
        }
        public IEnumerable<double> SumOfpayments()
        {
            return PaymentRepository.SumOfpayments();
        }
    }
}
