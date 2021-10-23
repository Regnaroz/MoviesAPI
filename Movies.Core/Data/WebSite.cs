using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Movies.Core.Data
{
    public class WebSite
    {
        [Key]
        public int Id { get; set; }
        public string LogoImg { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
