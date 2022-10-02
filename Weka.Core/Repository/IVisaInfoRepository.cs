using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;

namespace Weka.Core.Repository
{
    public interface IVisaInfoRepository
    {
        bool UpdateVisaInfo(VisaInfo visaInfo);
        bool CreateVisaInfo(VisaInfo visaInfo);
        List<VisaInfo> GetAllVisaInfo();
        bool DeleteVisaInfo(int id);
        bool Payment(int id);
    }
}
