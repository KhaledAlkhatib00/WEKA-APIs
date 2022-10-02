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
    [Route("api/[controller]")]
    [ApiController]
    public class ReferencessController : ControllerBase
    {
        private readonly IReferencessService referencessService;
        public ReferencessController(IReferencessService _referencessService)
        {
            referencessService = _referencessService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Referencess>), StatusCodes.Status200OK)]
        public List<Referencess> GetAllReferences()
        {
            return referencessService.GetAllReferences();
        }


        [HttpPost]
        [ProducesResponseType(typeof(Referencess), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateReferences([FromBody] Referencess referencess)
        {
            return referencessService.CreateReferences(referencess);
        }


        [HttpPut]
        [ProducesResponseType(typeof(Reports), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateReferences([FromBody] Referencess referencess)
        {
            return referencessService.UpdateReferences(referencess);
        }

        [HttpDelete]
        [ProducesResponseType(typeof(Referencess), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("delete/{id}")]
        public bool DeleteReferences(int id)
        {
            return referencessService.DeleteReferences(id);
        }
    }
}
