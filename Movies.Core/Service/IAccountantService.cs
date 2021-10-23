using Movies.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Core.Service
{
    public interface IAccountantService
    {
        public List<Accountant> GetAccountant();
        public bool InsertAccountant(Accountant accountant);
        public bool UpdateAccountant(Accountant accountant);
        public bool DeleteAccountant(int id);
    }
}
