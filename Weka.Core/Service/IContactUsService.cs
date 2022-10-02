using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;

namespace Weka.Core.Service
{
    public interface IContactUsService
    {
        bool CreateContactUs(ContactUs contactUs);
        List<ContactUs> GetAllContactUs();
        bool UpdateContactUs(ContactUs contactUs);
        bool DeleteContactUs(int id);
    }
}
