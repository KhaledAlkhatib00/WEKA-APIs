using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;

namespace Weka.Core.Service
{
    public interface IVisaInfoService
    {
        bool UpdateVisaInfo(VisaInfo visaInfo);
        bool CreateVisaInfo(VisaInfo visaInfo);
        List<VisaInfo> GetAllVisaInfo();
        bool DeleteVisaInfo(int id);
        bool Payment(int id);

    }
}
