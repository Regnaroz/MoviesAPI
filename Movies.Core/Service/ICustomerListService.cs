using Movies.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Core.Service
{
    public interface ICustomerListService
    {
        public List<CustomerList> GetCustomerList();
        public bool InsertCustomerList(CustomerList CustomerList);
        public bool UpdateCustomerList(CustomerList CustomerList);
        public bool DeleteCustomerList(int id);
    }
}
