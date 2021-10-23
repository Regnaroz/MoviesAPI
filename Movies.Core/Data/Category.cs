using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Movies.Core.Data

{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Movie> Movie { get; set; }
    }
}
