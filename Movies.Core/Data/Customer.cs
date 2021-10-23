using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Movies.Core.Data
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Img { get; set; }
        public decimal? Wallet { get; set; }
        public string VisaCard { get; set; }

        public virtual ICollection<Comments> Comments { get; set; }
        public virtual ICollection<CustomerList> CustomerList { get; set; }
        public virtual ICollection<Evaluation> Evaluation { get; set; }
        public virtual ICollection<History> History { get; set; }
        public virtual ICollection<Login> Login { get; set; }
        public virtual ICollection<Messenger> Messenger { get; set; }
        public virtual ICollection<Payment> Payment { get; set; }
        public virtual ICollection<Testimonial> Testimonial { get; set; }
    }
}
