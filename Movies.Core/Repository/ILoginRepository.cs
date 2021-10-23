using Movies.Core.Data;
using Movies.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Core.Repository
{
    public interface ILoginRepository
    {
        public List<Login> GetLogin();
        public bool InsertLogin(Login log);
        public bool UpdateLogin(Login log);
        public bool DeleteLogin(int id);
        public Login isUserExist(LoginDTO login);
        public bool UpdateVertification(NameVerificationDTO verificationDTO);
        public bool IsVertificationExist(NameVerificationDTO verificationDTO);
        public bool ResetPassword(LoginDTO login);
        public string GetCustomerEmail(string userName);

    }
}
