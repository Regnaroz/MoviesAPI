using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Core.DTO
{
    public class ResetPasswordDTO
    {
        public string userName { get; set; }
        public string password { get; set; }
        public int vertification { get; set; }
    }
}
