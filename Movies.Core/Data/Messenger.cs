using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.Core.Data
{
    public class Messenger
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("CustomerId")]
        public int? CustomerId { get; set; }
        [ForeignKey("AccountantId")]
        public int? AccountantId { get; set; }
        public string CustomerMeassage { get; set; }
        public string AccountantMessage { get; set; }
        public DateTime? Time { get; set; }

        public virtual Accountant Accountant { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
