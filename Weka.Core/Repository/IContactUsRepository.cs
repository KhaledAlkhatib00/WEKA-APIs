using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;

namespace Weka.Core.IRepository
{
    public interface IContactUsRepository
    {
        bool CreateContactUs(ContactUs contactUs);
        List<ContactUs> GetAllContactUs();
        bool UpdateContactUs(ContactUs contactUs);
        bool DeleteContactUs(int id);
    }
}
