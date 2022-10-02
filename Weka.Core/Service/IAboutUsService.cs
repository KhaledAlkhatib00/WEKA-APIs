using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;

namespace Weka.Core.Service
{
    public interface IAboutUsService
    {
        bool CreateAboutUs(AboutUs aboutUs);
        List<AboutUs> GetAllAboutUs();
        bool UpdateAboutUs(AboutUs aboutUs);
    }
}
