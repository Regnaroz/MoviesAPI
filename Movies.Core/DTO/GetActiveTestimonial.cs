using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Core.DTO
{
    public class GetActiveTestimonial
    {
        public int testeId { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string message { get; set; }
        public int? stars { get; set; }
        public string img { get; set; }
    }
}
