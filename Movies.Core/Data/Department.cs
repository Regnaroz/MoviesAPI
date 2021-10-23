using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Movies.Core.Data
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Login> Login { get; set; }
    }
}
