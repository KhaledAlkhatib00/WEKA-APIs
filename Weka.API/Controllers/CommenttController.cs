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
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class CommenttController : ControllerBase
    {
        private readonly ICommenttService commenttService;
        public CommenttController(ICommenttService _commenttService)
        {
            commenttService = _commenttService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Commentt>), StatusCodes.Status200OK)]
        public List<Commentt> GetAllComments()
        {
            return commenttService.GetAllComments();
        }


        [HttpPost]
        [ProducesResponseType(typeof(Commentt), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateComments([FromBody] Commentt commentt)
        {
            return commenttService.CreateComments(commentt);
        }


        [HttpPut]
        [ProducesResponseType(typeof(Commentt), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateComments([FromBody] Commentt commentt)
        {
            return commenttService.UpdateComments(commentt);
        }
        //GetArticleComments

        [HttpDelete]
        [ProducesResponseType(typeof(Commentt), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("{id}")]
        public bool DeleteComments(int id)
        {
            return commenttService.DeleteComments(id);
        }


        [HttpGet]
       
       
        public List<GetCountOfCommenttDTO> GetCountOfComment()
        {
            return commenttService.GetCountOfComment();
        }

        [HttpGet]

      
        public List<GetCountOfCommenttDTO> GetCountOfFavorite()
        {
            return commenttService.GetCountOfFavorite();
        }
    }
}
