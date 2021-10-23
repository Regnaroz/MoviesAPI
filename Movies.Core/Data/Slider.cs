using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Movies.Core.Data
{
    public class Slider
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
    }
}
