using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.Core.Data
{
    public class Testimonial
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("CustomerId")]
        public int? CustomerId { get; set; }
        public string Message { get; set; }
        public int? Stars { get; set; }
        public int? IsActive { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
