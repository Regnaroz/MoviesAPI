using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.Core.Data
{
    public class WorkingHours
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("AccountantId")]
        public int? AccountantId { get; set; }
        public DateTime? Date { get; set; }
        public int? Hours { get; set; }
        public int? Minutes { get; set; }
        public int? Seconds { get; set; }

        public virtual Accountant Accountant { get; set; }
    }
}
