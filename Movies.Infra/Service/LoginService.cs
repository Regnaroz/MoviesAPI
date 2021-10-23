using Microsoft.IdentityModel.Tokens;
using MimeKit;
using Movies.Core.Data;
using Movies.Core.DTO;
using Movies.Core.Repository;
using Movies.Core.Service;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Movies.Core.Settings;
using MailKit.Net.Smtp;

namespace Movies.Infra.Service
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository LoginRepository;
        public LoginService(ILoginRepository LoginRepository)
        {
            this.LoginRepository = LoginRepository;
        }

        public string Authentication(LoginDTO login)
        {
            var user = LoginRepository.isUserExist(login);
            string id;
            if (user != null)
            {
                if (user.AccountantId == null)
                {
                     id =Convert.ToString(user.CustomerId);
                }
                else
                {
                    id = Convert.ToString(user.AccountantId);
                }
                var tokenHand = new JwtSecurityTokenHandler();
                var tokenKey = Encoding.ASCII.GetBytes("[SECRET USED TO SIGN AND VERIFY JWT TOKENS, IT CAN BE ANY STRING]");
                var tokenDeesData = new SecurityTokenDescriptor()
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(ClaimTypes.Role,Convert.ToString(user.DepartmentId)),
                    new Claim(ClaimTypes.Name, id),

                    }),
                    Expires = DateTime.UtcNow.AddHours(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature),

                };
                var token = tokenHand.CreateToken(tokenDeesData);
                return tokenHand.WriteToken(token);


            }

            return null;
        }

        public bool DeleteLogin(int id)
        {
            return LoginRepository.DeleteLogin(id);
        }
        public List<Login> GetLogin()
        {
            return LoginRepository.GetLogin();
        }
        public bool InsertLogin(Login log)
        {
            return LoginRepository.InsertLogin(log);
        }

        public Login isUserExist(LoginDTO login)
        {
            return LoginRepository.isUserExist(login);
        }

        public bool ResetPassword(ResetPasswordDTO resetPassword)
        {
            NameVerificationDTO nameVerification = new NameVerificationDTO();
            nameVerification.userName = resetPassword.userName;
            nameVerification.vertification = resetPassword.vertification;
            if (LoginRepository.IsVertificationExist(nameVerification))
            {
                LoginDTO login = new LoginDTO();
                login.UserName = resetPassword.userName;
                login.Password = resetPassword.password;
                LoginRepository.ResetPassword(login);
                return true;
            }


            return false;
        }

        

        public bool UpdateLogin(Login log)
        {
            return UpdateLogin(log);
        }
    }
}
