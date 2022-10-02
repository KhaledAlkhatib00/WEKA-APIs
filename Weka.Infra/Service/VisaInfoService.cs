using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;
using Weka.Core.Repository;
using Weka.Core.Service;

namespace Weka.Infra.Service
{
    public class VisaInfoService : IVisaInfoService
    {
        private readonly IVisaInfoRepository visaInfoRepository;
        public VisaInfoService(IVisaInfoRepository _visaInfoRepository)
        {
            visaInfoRepository = _visaInfoRepository;
        }

        public bool CreateVisaInfo(VisaInfo visaInfo)
        {
            return visaInfoRepository.CreateVisaInfo(visaInfo);
        }

        public bool DeleteVisaInfo(int id)
        {
            return visaInfoRepository.DeleteVisaInfo(id);
        }

        public List<VisaInfo> GetAllVisaInfo()
        {
            return visaInfoRepository.GetAllVisaInfo();
        }

        public bool Payment(int id)
        {
            return visaInfoRepository.Payment(id);
        }
        public bool UpdateVisaInfo(VisaInfo visaInfo)
        {
            return visaInfoRepository.UpdateVisaInfo(visaInfo);
        }
    }
}
