using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Core.DTO
{
    public class MovieCatDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int categoryId { get; set; }
        public string Language { get; set; }
        public string StoryLine { get; set; }
        public string Img { get; set; }
        public string TrailerUrl { get; set; }
        public string Video { get; set; }
        public string Country { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public decimal? Price { get; set; }
    }
}
