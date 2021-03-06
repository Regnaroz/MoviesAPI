using Movies.Core.Data;
using Movies.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Core.Repository
{
    public interface ITestimonialRepository
    {
        public List<Testimonial> GetTestimonial();
        public bool InsertTestimonial(Testimonial Testimonial);
        public bool UpdateTestimonial(Testimonial Testimonial);
        public bool DeleteTestimonial(int id);
        public List<GetActiveTestimonial> GetActiveTestimonial();

    }
}
