using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;
using Weka.Core.Repository;
using Weka.Core.Service;

namespace Weka.Infra.Service
{
    public class AboutUsService : IAboutUsService
    {
        private readonly IAboutUsRepository _aboutUsRepository;
        public AboutUsService(IAboutUsRepository aboutUsRepository)
        {
            _aboutUsRepository = aboutUsRepository;
        }
        public bool CreateAboutUs(AboutUs aboutUs)
        {
           return _aboutUsRepository.CreateAboutUs(aboutUs);
        }

        public List<AboutUs> GetAllAboutUs()
        {
            return _aboutUsRepository.GetAllAboutUs();
        }

        public bool UpdateAboutUs(AboutUs aboutUs)
        {
            return _aboutUsRepository.UpdateAboutUs(aboutUs);
        }
    }
}
