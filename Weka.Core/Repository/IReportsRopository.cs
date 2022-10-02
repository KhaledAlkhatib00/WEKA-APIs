using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;
using Weka.Core.DTO;

namespace Weka.Core.Repository
{
    public interface IReportsRopository
    {
        bool UpdateReports( Reports reports );
        bool CreateReports(  Reports reports );
        List<AllReportsInfoDTO> GetAllReports();
        bool DeleteReports(int id);
    }
}
