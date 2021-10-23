using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.Core.Data
{
    public class Tasks
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("AccountantId")]
        public int? AccountantId { get; set; }
        public string Task { get; set; }
        public int? IsDone { get; set; }

        public virtual Accountant Accountant { get; set; }
    }
}
