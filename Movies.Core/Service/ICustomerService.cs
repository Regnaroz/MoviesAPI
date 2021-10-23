using Movies.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Core.Service
{
    public interface ICustomerService
    {
        public List<Customer> GetCustomer();
        public bool InsertCustomer(Customer customer);
        public bool UpdateCustomer(Customer customer);
        public bool DeleteCustomer(int id);
    }
}
