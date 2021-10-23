using Movies.Core.Data;
using Movies.Core.Repository;
using Movies.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Infra.Service
{
    public class ContactUsService : IContactUsService
    {
        private readonly IContactUsRepository ContactUsRepository;
        public ContactUsService(IContactUsRepository ContactUsRepository)
        {
            this.ContactUsRepository = ContactUsRepository;
        }
             
        public bool DeleteContactUs(int id)
        {
            return ContactUsRepository.DeleteContactUs(id);
        }

        public List<ContactUs> GetContactUs()
        {
            return ContactUsRepository.GetContactUs();
        }

        public bool InsertContactUs(ContactUs ContactUs)
        {
            return ContactUsRepository.InsertContactUs(ContactUs);
        }

        public bool UpdateContactUs(ContactUs ContactUs)
        {
            return ContactUsRepository.UpdateContactUs(ContactUs);
        }
    }
}
