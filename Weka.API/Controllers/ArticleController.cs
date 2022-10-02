using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Weka.Core.Data;
using Weka.Core.DTO;
using Weka.Core.Service;

namespace Weka.API.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class ArticleController : Controller
    {
        private readonly IArticleService articleService;
        public ArticleController(IArticleService _articleService)
        {
            articleService = _articleService;
        }
        [HttpGet]

        [ProducesResponseType(typeof(List<Article>), StatusCodes.Status200OK)]
        public List<Article> GetAllArticle()
        {
            return articleService.GetAllArticle();
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<PostInformationDTO>), StatusCodes.Status200OK)]
        public List<PostInformationDTO> GetTopFiveArticle()
        {
            return articleService.GetTopFiveArticle();
        }
        
        [HttpGet]
        [ProducesResponseType(typeof(List<PostInformationDTO>), StatusCodes.Status200OK)]
        public List<PostInformationDTO> GetAllPostsNewInfo()
        {
            return articleService.GetAllPostsNewInfo();
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<PostInformationDTO>), StatusCodes.Status200OK)]
        public List<PostInformationDTO> GetRecentPosts()
        {
            return articleService.GetRecentPosts();
        }


        [HttpPost]
        public bool CreateArticle([FromBody] Article article)
        {
            return articleService.CreateArticle(article);
        }

        [HttpPut]
        [ProducesResponseType(typeof(List<Article>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateArticle([FromBody] Article article)
        {
            return articleService.UpdateArticle(article);
        }
        [HttpDelete]
        [Route("{id}")]
        public bool DeleteArticle(int id)
        {
            return articleService.DeleteArticle(id);
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<CountOfArticleDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<CountOfArticleDTO> GetCountOfArticle()
        {
            return articleService.GetCountOfArticle();
        }
        [HttpPost]
        [ProducesResponseType(typeof(List<CountOfFavoriteDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("{id}")]
        public List<CountOfFavoriteDTO> GetCountOfFavorite(int id)
        {
            return articleService.GetCountOfFavorite(id);
        }
        [HttpPost]
        [ProducesResponseType(typeof(List<GetCountOfLikeDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("{id}")]
        public List<GetCountOfLikeDTO> GetCountOfLike(int id)
        {
            return articleService.GetCountOfLike(id);
        }
        [HttpPost]
        [ProducesResponseType(typeof(List<GetCountOfCommenttDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("{id}")]
        public List<GetCountOfCommenttDTO> GetCountOfCommentt(int id)
        {
            return articleService.GetCountOfCommentt(id);
        }

        [HttpPost]
        [Route("{id}")]
        [ProducesResponseType(typeof(List<PostInformationDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<PostInformationDTO> FillterArticleByCategory(int id)
        {
            return articleService.FillterArticleByCategory(id);
        }

        [HttpPost]
        [ProducesResponseType(typeof(List<PostInformationDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<PostInformationDTO> SearchArticle([FromBody] Article article)
        {
            return articleService.SearchArticle(article);
        }

        [HttpPost]
        [Route("{id}")]
        [ProducesResponseType(typeof(List<Aouther>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Aouther> GetArticleAouther(int id)
        {
            return articleService.GetArticleAouther(id);
        }

        [HttpPost]
        [Route("{id}")]
        [ProducesResponseType(typeof(List<CommentInfo>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<CommentInfo> GetArticleComments(int id)
        {
            return articleService.GetArticleComments(id);
        }

        [HttpPost]
        [Route("{id}")]
        [ProducesResponseType(typeof(List<ArticleLikesDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<ArticleLikesDTO> GetArticleLikes(int id)
        {
            return articleService.GetArticleLikes(id);
        }

        [HttpPost]
        [Route("{id}")]
        [ProducesResponseType(typeof(List<Article>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Article> GetUserArticle(int id)
        {
            return articleService.GetUserArticle(id);
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<ReportDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<ReportDTO> ArticleReport()
        {
            return articleService.ArticleReport();
        }

        [HttpGet]
        [Route("{id}")]
        public bool BlockArticle(int id)
        {
            return articleService.BlockArticle(id);
        }

        [HttpGet]
        [Route("{id}")]
        public bool UnBlockArticle(int id)
        {
            return articleService.UnBlockArticle(id);
        }

        [HttpGet]
        [Route("{id}")]
        public bool PublishArticle(int id)
        {
            return articleService.PublishArticle(id);

        }

        [HttpPost]
        public bool CreateBlockedArticle([FromBody] Article article)
        {
            return articleService.CreateBlockedArticle(article);
        }

        ////[HttpPost]
        ////[Route("uploadImage")]
        ////public Article UploadImage()
        ////{
        ////    try
        ////    {
        ////        var file = Request.Form.Files[0]; // Image  that we uploaded
        ////        var fileName = Guid.NewGuid().ToString() + "_"
        ////        + file.FileName;// jbxhvxvx_img.jpg, shbbxhsb_img.jpg
        ////        var fullPath = Path.Combine("D:\\wekav2\\weka\\src\\assets\\Images\\",
        ////        fileName);
        ////        using (var stream = new FileStream(fullPath, FileMode.Create))
        ////        {
        ////            file.CopyTo(stream);
        ////        }
        ////        Article Item = new Article();
        ////        Item.ArticleImage = fileName;
        ////        return Item;
        ////    }
        ////    catch (Exception e)
        ////    {
        ////        return null;
        ////    }
        ////}

        [HttpPost]
        public Article UploadImage()
        {
            try
            {
                var file = Request.Form.Files[0];
                byte[] fileContant;
                using (var ms = new MemoryStream())
                {
                    file.CopyTo(ms);
                    fileContant = ms.ToArray();
                }
                var fileName = Path.GetFileNameWithoutExtension(file.FileName);
                string attachmentFileName = $"{fileName}.{Path.GetExtension(file.FileName).Replace(".", "")}";
                var fullPath = Path.Combine("D:\\wekav2\\weka\\src\\assets\\Images\\", attachmentFileName);
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                Article Item = new Article();
                Item.ArticleImage = attachmentFileName;
                return Item;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpGet]

        [ProducesResponseType(typeof(List<Article>), StatusCodes.Status200OK)]
        public List<Article> GetArticles()
        {
            return articleService.GetArticles();
        }


    }
}
