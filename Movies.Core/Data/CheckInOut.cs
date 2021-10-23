using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.Core.Data
{
    public class CheckInOut
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("AccountantId")]
        public int? AccountantId { get; set; }
        public DateTime? CheckInTime { get; set; }
        public DateTime? CheckOutTime { get; set; }

        public virtual Accountant Accountant { get; set; }
    }
}
