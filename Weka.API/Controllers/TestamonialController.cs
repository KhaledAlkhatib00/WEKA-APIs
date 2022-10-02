using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Weka.Core.Data;
using Weka.Core.DTO;
using Weka.Core.Service;

namespace Weka.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestamonialController : Controller
    {
        private readonly ITestamonialService testamonialService;
        public TestamonialController(ITestamonialService _testamonialService)
        {
            testamonialService = _testamonialService;
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<TestimonialDTO>),StatusCodes.Status200OK)]
        public List<TestimonialDTO> GetAllTestamoniall()
        {
            return testamonialService.GetAllTestamonial();
        }

        [HttpGet]
        [Route("GetTestimonialForm")]
        [ProducesResponseType(typeof(List<homeTestimonial>), StatusCodes.Status200OK)]
        public List<homeTestimonial> GetTestimonialForm()
        {
            return testamonialService.GetTestimonialForm();
        }

        [HttpPost]
        [ProducesResponseType(typeof(Testamoniall),StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateTestamonial([FromBody] Testamoniall testamoniall)
        {
            return testamonialService.CreateTestamonial(testamoniall);
        }

        [HttpPut]
        [ProducesResponseType(typeof(List<Testamoniall>),StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateTestamonial([FromBody] Testamoniall testamoniall)
        {
            return testamonialService.UpdateTestamonial(testamoniall);
        }
        [HttpDelete]
        [Route("delete/{id}")]
        public bool DeleteTestamonial(int id)
        {
            return testamonialService.DeleteTestamonial(id);
        }

        [HttpGet]
        [Route("HideTestimonial/{id}")]
        public bool HideTestimonial(int id)
        {
            return testamonialService.HideTestimonial(id);
        }

        [HttpGet]
        [Route("ShowTestimonial/{id}")]
        public bool ShowTestimonial(int id)
        {
            return testamonialService.ShowTestimonial(id);
        }

    }
}
