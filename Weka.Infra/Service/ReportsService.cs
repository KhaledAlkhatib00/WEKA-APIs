using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;
using Weka.Core.DTO;
using Weka.Core.Repository;
using Weka.Core.Service;

namespace Weka.Infra.Service
{
    public class ReportsService : IReportsService
    {
        private readonly IReportsRopository reportsRepository;
        public ReportsService(IReportsRopository _reportsRepository)
        {
            reportsRepository = _reportsRepository;
        }

        public bool CreateReports(Reports reports)
        {
            return reportsRepository.CreateReports(reports);
        }

        public bool DeleteReports(int id)
        {
            return reportsRepository.DeleteReports(id);
        }

        public List<AllReportsInfoDTO> GetAllReports()
        {
            return reportsRepository.GetAllReports();
        }

        public bool UpdateReports(Reports reports)
        {
            return reportsRepository.UpdateReports(reports);
        }
    }
}
