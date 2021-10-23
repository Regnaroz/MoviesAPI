using Movies.Core.Data;
using Movies.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Core.Service
{
    public interface ILoginService
    {
        public List<Login> GetLogin();
        public bool InsertLogin(Login log);
        public bool UpdateLogin(Login log);
        public bool DeleteLogin(int id);
        public string Authentication(LoginDTO login);
        public bool ResetPassword(ResetPasswordDTO resetPassword);
        public Login isUserExist(LoginDTO login);
    }
}
