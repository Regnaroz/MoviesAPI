using Microsoft.Extensions.Options;
using MimeKit;
using MailKit.Net.Smtp;
using Movies.Core.DTO;
using Movies.Core.Repository;
using Movies.Core.Service;
using Movies.Core.Settings;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Infra.Service
{
    public class MailService : IMailService
    {
        private readonly MailSettings _mailSettings;
        private readonly ILoginRepository loginRepository;
        public MailService(IOptions<MailSettings> mailSettings, ILoginRepository loginRepository)
        {
            _mailSettings = mailSettings.Value;
            this.loginRepository = loginRepository;
        }
        public async Task SendVerification(string username)
        {
            Random random = new Random();
            int newVerification = random.Next(1000, 9999);
            NameVerificationDTO nameVerification = new NameVerificationDTO();
            nameVerification.userName = username;
            nameVerification.vertification = newVerification;
            loginRepository.UpdateVertification(nameVerification);


            string email = loginRepository.GetCustomerEmail(username);

            MimeMessage message = new MimeMessage();

            MailboxAddress from = new MailboxAddress("Movies",
            "ramiabuagolah40@gmail.com");
            message.From.Add(from);


            MailboxAddress to = new MailboxAddress("Customer",
             email);
            message.To.Add(to);

            message.Subject = "Verification Code";


            BodyBuilder bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = "Hello" +
            "<br>Your verification code is:  " + newVerification;
            message.Body = bodyBuilder.ToMessageBody();

            using (var clinte = new SmtpClient())
            {
                clinte.Connect("smtp.gmail.com", 587, false);
                clinte.Authenticate("ramiabuagolah40@gmail.com", "/*//*/*/*/");// Your Email and password



                clinte.Send(message);
                clinte.Disconnect(true);
            }


        }
    }
}
