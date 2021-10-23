using Movies.Core.Data;
using Movies.Core.Repository;
using Movies.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Infra.Service
{
    public class AccountantService : IAccountantService
    {
        private readonly IAccountantRepository accountantRepository;
        public AccountantService(IAccountantRepository accountantRepository)
        {
            this.accountantRepository = accountantRepository;
        }

        public bool DeleteAccountant(int id)
        {
            return accountantRepository.DeleteAccountant(id);
        }

        public List<Accountant> GetAccountant()
        {
            return accountantRepository.GetAccountant();
        }

        public bool InsertAccountant(Accountant accountant)
        {
            return accountantRepository.InsertAccountant(accountant);
        }

        public bool UpdateAccountant(Accountant accountant)
        {
            return accountantRepository.UpdateAccountant(accountant);
        }
    }
}
