using Movies.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Core.Repository
{
    public interface IAboutUsRepository
    {
        public List<AboutUs> GetAboutUs();
        public bool InsertAboutUs(AboutUs aboutUs);
        public bool UpdateCourse(AboutUs aboutUs);
        public bool DeleteAboutUs(int id);
    }
}
