using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Core.Service
{
    public interface IMailService
    {
       public Task SendVerification(string userName);
    }
}
