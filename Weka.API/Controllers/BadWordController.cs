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
    public class BadWordController : ControllerBase
    {
        private readonly IBadWordService badWordService;
        public BadWordController(IBadWordService _badWordService)
        {
            badWordService = _badWordService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<BadWord>), StatusCodes.Status200OK)]
        public List<BadWord> GetAllBadWord()
        {
            return badWordService.GetAllBadWord();
        }


        [HttpPost]
        [ProducesResponseType(typeof(BadWord), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateBadWord([FromBody] BadWord badWord)
        {
            return badWordService.CreateBadWord(badWord);
        }


        [HttpPut]
        [ProducesResponseType(typeof(BadWord), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateBadWord([FromBody] BadWord badWord)
        {
            return badWordService.UpdateBadWord(badWord);
        }

        [HttpDelete]
        [ProducesResponseType(typeof(BadWord), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("delete/{id}")]
        public bool DeleteBadWord(int id)
        {
            return badWordService.DeleteBadWord(id);
        }
    }
}
