using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.Core.Data
{
    public class Evaluation
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("CustomerId")]
        public int? CustomerId { get; set; }
        [ForeignKey("MovieId")]
        public int? MovieId { get; set; }
        public int? Stars { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
