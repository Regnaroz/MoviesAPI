using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.Core.Data
{
    public class Login
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        [ForeignKey("DepartmentId")]
        public int? DepartmentId { get; set; }
        [ForeignKey("AccountantId")]
        public int? AccountantId { get; set; }
        [ForeignKey("CustomerId")]
        public int? CustomerId { get; set; }
        public int? Verification { get; set; }

        public virtual Accountant Accountant { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Department Department { get; set; }
    }
}
