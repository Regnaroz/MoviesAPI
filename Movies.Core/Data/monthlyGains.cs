using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Core.Data
{
    public class monthlyGains
    {

       public int month { get; set; }
        public int year { get; set; }    
        public double MoviesGains { get; set; }
        public int MoviesBought { get; set; }
        public double EmployeeSalaries { get; set; }
       public double  Total { get; set; }

    }
}
