using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.Core.Data
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public string Language { get; set; }
        public string StoryLine { get; set; }
        public string Img { get; set; }
        public string TrailerUrl { get; set; }
        public string Video { get; set; }
        public string Country { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public decimal? Price { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
        public virtual ICollection<CustomerList> CustomerList { get; set; }
        public virtual ICollection<Evaluation> Evaluation { get; set; }
        public virtual ICollection<History> History { get; set; }
        public virtual ICollection<Payment> Payment { get; set; }
    }
}
