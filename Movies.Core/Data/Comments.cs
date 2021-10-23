using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.Core.Data
{
    public class Comments
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("CustomerId")]
        public int? CustomerId { get; set; }
        [ForeignKey("MovieId")]
        public int? MovieId { get; set; }
        public string Message { get; set; }
        public DateTime? Time { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
