using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;

namespace Weka.Core.Repository
{
    public interface IAboutUsRepository
    {
        bool CreateAboutUs(AboutUs aboutUs);
        List<AboutUs> GetAllAboutUs();
        bool UpdateAboutUs(AboutUs aboutUs);
    }
}
