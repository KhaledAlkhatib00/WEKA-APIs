using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Weka.Core.Data;
using Weka.Core.Service;

namespace Weka.API.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class VisaInfoController : ControllerBase
    {
        private readonly IVisaInfoService visaInfoService;
        public VisaInfoController(IVisaInfoService _visaInfoService)
        {
            visaInfoService = _visaInfoService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<VisaInfo>), StatusCodes.Status200OK)]
        public List<VisaInfo> GetAllVisaInfo()
        {
            return visaInfoService.GetAllVisaInfo();
        }


        [HttpPost]
        [ProducesResponseType(typeof(VisaInfo), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateVisaInfo([FromBody] VisaInfo visaInfo)
        {
            return visaInfoService.CreateVisaInfo(visaInfo);
        }


        [HttpPut]
        [ProducesResponseType(typeof(VisaInfo), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateVisaInfo([FromBody] VisaInfo visaInfo)
        {
            return visaInfoService.UpdateVisaInfo(visaInfo);
        }

        [HttpDelete]
        [ProducesResponseType(typeof(VisaInfo), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("{id}")]
        public bool DeleteVisaInfo(int id)
        {
            return visaInfoService.DeleteVisaInfo(id);
        }

        [HttpPost]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Payment(int id)
        {
            return visaInfoService.Payment(id);
        }
    }
}
