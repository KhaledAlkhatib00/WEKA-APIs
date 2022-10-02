using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;
using Weka.Core.DTO;

namespace Weka.Core.IRepository
{
    public interface IArticleRepository
    {
        bool CreateArticle(Article article);
        List<Article> GetAllArticle();
        bool UpdateArticle(Article article);
        bool DeleteArticle(int id);
        List<CountOfArticleDTO> GetCountOfArticle();
        List<CountOfFavoriteDTO> GetCountOfFavorite(int id);
        List<GetCountOfLikeDTO> GetCountOfLike(int id);
        List<GetCountOfCommenttDTO> GetCountOfCommentt(int id);
        List<PostInformationDTO> FillterArticleByCategory(int id);
        List<PostInformationDTO> SearchArticle(Article article);
        List<PostInformationDTO> GetTopFiveArticle();
        List<PostInformationDTO> GetRecentPosts();
        List<PostInformationDTO> GetAllPostsNewInfo();
        List<Aouther> GetArticleAouther(int id);
        List<CommentInfo> GetArticleComments(int id);
        List<ArticleLikesDTO>GetArticleLikes(int id);
        List<Article> GetUserArticle(int id);
        List<ReportDTO> ArticleReport();

        bool BlockArticle(int id);
        bool UnBlockArticle(int id);
        bool PublishArticle(int id);
        bool CreateBlockedArticle(Article article);


        List<Article> GetArticles();

    }
}
