using Movies.Core.Data;
using Movies.Core.Repository;
using Movies.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Infra.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public bool DeleteCustomer(int id)
        {
            return customerRepository.DeleteCustomer(id);
        }

        public List<Customer> GetCustomer()
        {
            return customerRepository.GetCustomer();
        }

        public bool InsertCustomer(Customer customer)
        {
            return customerRepository.InsertCustomer(customer);
        }

        public bool UpdateCustomer(Customer customer)
        {
            return customerRepository.UpdateCustomer(customer);
        }
    }
}
