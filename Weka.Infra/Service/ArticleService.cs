using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;
using Weka.Core.DTO;
using Weka.Core.IRepository;
using Weka.Core.Service;

namespace Weka.Infra.Service
{
    public class ArticleService: IArticleService
    {
        private readonly IArticleRepository ArticleRepository;
        public ArticleService(IArticleRepository _articleRepository)
        {
            ArticleRepository = _articleRepository;

        }

        public bool CreateArticle(Article article)
        {
            return ArticleRepository.CreateArticle(article);
        }

        public bool DeleteArticle(int id)
        {
            return ArticleRepository.DeleteArticle(id);

        }

        public List<PostInformationDTO> FillterArticleByCategory(int id)
        {
            return ArticleRepository.FillterArticleByCategory(id);
        }

        public List<Article> GetAllArticle()
        {
            return ArticleRepository.GetAllArticle();

        }
        public List<Article> GetArticles()
        {
            return ArticleRepository.GetArticles();

        }

        public List<PostInformationDTO> GetTopFiveArticle()
        {
            return ArticleRepository.GetTopFiveArticle();
        } 
        public List<PostInformationDTO> GetAllPostsNewInfo()
        {
            return ArticleRepository.GetAllPostsNewInfo();
        } 
        public List<PostInformationDTO> GetRecentPosts()
        {
            return ArticleRepository.GetRecentPosts();
        }

        public List<CountOfArticleDTO> GetCountOfArticle()
        {
            return ArticleRepository.GetCountOfArticle();
        }

        public List<GetCountOfCommenttDTO> GetCountOfCommentt(int id)
        {
            return ArticleRepository.GetCountOfCommentt(id);
        }

        public List<CountOfFavoriteDTO> GetCountOfFavorite(int id)
        {
            return ArticleRepository.GetCountOfFavorite(id);
        }

        public List<GetCountOfLikeDTO> GetCountOfLike(int id)
        {
            return ArticleRepository.GetCountOfLike(id);
        }


        public List<PostInformationDTO> SearchArticle(Article article)
        {
            return ArticleRepository.SearchArticle(article);
        }

        public bool UpdateArticle(Article article)
        {
            return ArticleRepository.UpdateArticle(article);
        }

        public List<Aouther> GetArticleAouther(int id)
        {
            return ArticleRepository.GetArticleAouther(id);
        }

        public List<CommentInfo> GetArticleComments(int id)
        {
            return ArticleRepository.GetArticleComments(id);
        }

        public List<Article> GetUserArticle(int id)
        {
            return ArticleRepository.GetUserArticle(id);
        }

        public List<ArticleLikesDTO> GetArticleLikes(int id)
        {
            return ArticleRepository.GetArticleLikes(id);
        }

        public List<ReportDTO> ArticleReport()
        {
            return ArticleRepository.ArticleReport();
        }

        public bool BlockArticle(int id)
        {
            return ArticleRepository.BlockArticle(id);
        }

        public bool UnBlockArticle(int id)
        {
            return ArticleRepository.UnBlockArticle(id);
        }

        public bool PublishArticle(int id)
        {
        return ArticleRepository.PublishArticle(id);
        }

        public bool CreateBlockedArticle(Article article)
        {
            return ArticleRepository.CreateBlockedArticle(article);
        }
    }
}
