using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Weka.Core.Data;
using Weka.Core.DTO;
using Weka.Core.Service;

namespace Weka.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        private readonly IReportsService reportsService;
        public ReportsController(IReportsService _reportsService)
        {
            reportsService = _reportsService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<AllReportsInfoDTO>),StatusCodes.Status200OK)]
        public List<AllReportsInfoDTO> GetAllReports()
        {
            return reportsService.GetAllReports();
        }
        
        
        [HttpPost]
        [ProducesResponseType(typeof(Reports), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateReports([FromBody] Reports reports)
        {
            return reportsService.CreateReports(reports);
        }


        [HttpPut]
        [ProducesResponseType(typeof(Reports), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateReports([FromBody] Reports reports)
        {
            return reportsService.UpdateReports(reports);
        }

        [HttpDelete]
        [ProducesResponseType(typeof(Reports), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("delete/{id}")]
        public bool DeleteReports(int id)
        {
            return reportsService.DeleteReports(id);
        }

    }
}
