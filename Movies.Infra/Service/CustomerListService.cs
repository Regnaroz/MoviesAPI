using Movies.Core.Data;
using Movies.Core.Repository;
using Movies.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Infra.Service
{
    public class CustomerListService : ICustomerListService
    {
        private readonly ICustomerListRepository CustomerListRepository;
        public CustomerListService(ICustomerListRepository CustomerListRepository)
        {
            this.CustomerListRepository = CustomerListRepository;
        }

        public bool DeleteCustomerList(int id)
        {
            return CustomerListRepository.DeleteCustomerList(id);
        }

        public List<CustomerList> GetCustomerList()
        {
            return CustomerListRepository.GetCustomerList();
        }

        public bool InsertCustomerList(CustomerList CustomerList)
        {
            return CustomerListRepository.InsertCustomerList(CustomerList);
        }

        public bool UpdateCustomerList(CustomerList CustomerList)
        {
            return CustomerListRepository.UpdateCustomerList(CustomerList);
        }
    }
}
