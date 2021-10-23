using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Core.Service
{
    public interface IMailService
    {
        Task SendVerification(string userName);
    }
}
