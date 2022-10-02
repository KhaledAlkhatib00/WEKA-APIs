using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;
using Weka.Core.IRepository;
using Weka.Core.Service;

namespace Weka.Infra.Service
{
    public class ContactUsService : IContactUsService
    {

        private readonly IContactUsRepository contactUsRepository;
        public ContactUsService(IContactUsRepository _contactUsRepository)
        {
            contactUsRepository = _contactUsRepository;

        }

        public bool CreateContactUs(ContactUs contactUs)
        {
            return contactUsRepository.CreateContactUs(contactUs);
        }

        public bool DeleteContactUs(int id)
        {
            return contactUsRepository.DeleteContactUs( id);
        }

        public List<ContactUs> GetAllContactUs()
        {
            return contactUsRepository.GetAllContactUs();
        }

        public bool UpdateContactUs(ContactUs contactUs)
        {
            return contactUsRepository.UpdateContactUs(contactUs);
        }
    }
}