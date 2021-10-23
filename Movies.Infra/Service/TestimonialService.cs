using Movies.Core.Data;
using Movies.Core.Repository;
using Movies.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Infra.Service
{
    public class TestimonialService : ITestimonialService
    {
        private readonly ITestimonialRepository TestimonialRepository;
        public TestimonialService(ITestimonialRepository TestimonialRepository)
        {
            this.TestimonialRepository = TestimonialRepository;
        }
        public bool DeleteTestimonial(int id)
        {
            return TestimonialRepository.DeleteTestimonial(id);
        }

        public List<Testimonial> GetActiveTestimonial()
        {
            return TestimonialRepository.GetActiveTestimonial();
        }

        public List<Testimonial> GetTestimonial()
        {
            return TestimonialRepository.GetTestimonial();
        }

        public bool InsertTestimonial(Testimonial Testimonial)
        {
            return TestimonialRepository.InsertTestimonial(Testimonial);
        }

        public bool UpdateTestimonial(Testimonial Testimonial)
        {
            return TestimonialRepository.UpdateTestimonial(Testimonial);
        }
    }
}
