using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.Core.Data
{
    public class Expenses
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("AccountantId")]
        public int? AccountantId { get; set; }
        public decimal? Value { get; set; }
        public DateTime? Time { get; set; }

        public virtual Accountant Accountant { get; set; }
    }
}
