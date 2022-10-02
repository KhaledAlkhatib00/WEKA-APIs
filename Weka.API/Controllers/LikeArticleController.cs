using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Weka.Core.Data;
using Weka.Core.DTO;
using Weka.Core.Service;

namespace Weka.API.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class LikeArticleController : Controller
    {
        private readonly ILikeArticleService likeArticleService;
        public LikeArticleController(ILikeArticleService _likeArticleService)
        {
            likeArticleService = _likeArticleService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(LikeArticle), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateLike([FromBody] LikeArticle likeArticle)
        {
            return likeArticleService.CreateLike(likeArticle);
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<LikeArticle>), StatusCodes.Status200OK)]
        public List<LikeArticle> GetAllLikes()
        {
            return likeArticleService.GetAllLikes();
        }

        [HttpDelete]
        [ProducesResponseType(typeof(BadWord), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("{id}")]
        public bool DeleteLike(int id)
        {
            return likeArticleService.DeleteLike(id);
        }

        [HttpGet]
        [Route("{id}")]
        public bool PublishTheArticle(int id)
        {
            return likeArticleService.PublishTheArticle(id);
        }

        [HttpGet]
        
        [ProducesResponseType(typeof(List<GetTheProfetDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<GetTheProfetDTO> GetTheProfet()
        {
            return likeArticleService.GetTheProfet();
        }
        [HttpGet]
       
        [ProducesResponseType(typeof(List<GetTheLossesDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<GetTheLossesDTO> GetTheLosses()
        {
            return likeArticleService.GetTheLosses();
        }

        [HttpGet]
        [Route("{id}")]
        public bool BlockArticle(int id)
        {
            return likeArticleService.BlockArticle(id);
        }


        [HttpGet]
        [Route("{id}")]
        public bool UnBlockArticle(int id)
        {
            return likeArticleService.UnBlockArticle(id);
        }
    }
}
