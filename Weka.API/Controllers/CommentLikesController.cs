using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Weka.Core.Data;
using Weka.Core.DTO;
using Weka.Core.Service;
using Weka.Infra.Service;

namespace Weka.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentLikesController : Controller
    {
        private readonly ICommentLikesService commentLikesService;
        public CommentLikesController(ICommentLikesService _commentLikesService)
        {
            commentLikesService = _commentLikesService;
        }
        [HttpPost]
        [ProducesResponseType(typeof(CommentLikes), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateCommentLikes([FromBody] CommentLikes commentLikes)
        {
            return commentLikesService.CreateCommentLikes(commentLikes);
        }


        [HttpPut]
        [ProducesResponseType(typeof(CommentLikes), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateCommentLikes([FromBody] CommentLikes commentLikes)
        {
            return commentLikesService.UpdateCommentLikes(commentLikes);
        }

        [HttpDelete]
        [ProducesResponseType(typeof(CommentLikes), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("delete/{id}")]
        public bool DeleteCommentLikes(int id)
        {
            return commentLikesService.DeleteCommentLikes(id);
        }
        [HttpGet]
        [Route("{id}")]
        public List<GetCountOfLikeDTO> GetCommentLike(int id)
        {
            return commentLikesService.GetCommentLike(id);
        }
    }
}
