using Movies.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Core.Repository
{
    public interface IContactUsRepository
    {
        public List<ContactUs> GetContactUs();
        public bool InsertContactUs(ContactUs ContactUs);
        public bool UpdateContactUs(ContactUs ContactUs);
        public bool DeleteContactUs(int id);
    }
}
