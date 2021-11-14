﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Core.DTO
{
   public class trendingMovies
    {
        public int movieId { get; set; }
        public string Name { get; set; }
        public string CategoryId { get; set; }
        public string Img { get; set; }
        public string TrailerUrl { get; set; }
        public string Video { get; set; }
        public string Country { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public decimal? Price { get; set; }
        public int purchaceCount { get; set; }
    }
}
