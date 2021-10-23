using Movies.Core.Data;
using Movies.Core.Repository;
using Movies.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Infra.Service
{
    public class AboutUsService : IAboutUsService
    {
        private readonly IAboutUsRepository aboutUsRepository;
        public AboutUsService(IAboutUsRepository aboutUsRepository)
        {
            this.aboutUsRepository = aboutUsRepository;
        }

        public bool DeleteAboutUs(int id)
        {
            return aboutUsRepository.DeleteAboutUs(id);
        }

        public List<AboutUs> GetAboutUs()
        {
            return aboutUsRepository.GetAboutUs();
        }

        public bool InsertAboutUs(AboutUs aboutUs)
        {
            return aboutUsRepository.InsertAboutUs(aboutUs);
        }

        public bool UpdateCourse(AboutUs aboutUs)
        {
            return aboutUsRepository.UpdateCourse(aboutUs);
        }
    }
}
