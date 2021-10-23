using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Movies.Core.Data
{
    public class Accountant
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public decimal? Wallet { get; set; }
        public decimal? Salary { get; set; }
        public string Img { get; set; }

        public virtual ICollection<CheckInOut> CheckInOut { get; set; }
        public virtual ICollection<Expenses> Expenses { get; set; }
        public virtual ICollection<Login> Login { get; set; }
        public virtual ICollection<Messenger> Messenger { get; set; }
        public virtual ICollection<Tasks> Tasks { get; set; }
        public virtual ICollection<WorkingHours> WorkingHours { get; set; }
    }
}
