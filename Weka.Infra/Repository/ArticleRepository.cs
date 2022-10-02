using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Dapper;
using Weka.Core.Common;
using Weka.Core.Data;
using Weka.Core.DTO;
using Weka.Core.IRepository;

namespace Weka.Infra.Repository
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly IDbContext DbContext;
        public ArticleRepository(IDbContext _dbContext)
        {
            DbContext = _dbContext;
        }
        public bool CreateArticle(Article article)
        {
            var p = new DynamicParameters();
            p.Add("@AArticleTitle", article.ArticleTitel, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@AArticleGrapgh", article.ArticleGrapgh, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@APublishDate", article.PublishDate, dbType: DbType.Date, ParameterDirection.Input);
            p.Add("@ACategoryId", article.CategoryId, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("@AArticleImage", article.ArticleImage, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@AUserId", article.UserId, dbType: DbType.Int32, ParameterDirection.Input);

            var result = DbContext.Connection.ExecuteAsync("Article_Package.CreateArticle",
                p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteArticle(int id)
        {
            var p = new DynamicParameters();
            p.Add("@AId", id, dbType: DbType.Int32, ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("Article_Package.DeleteArticle",
                p, commandType: CommandType.StoredProcedure);
            return true;
        }

      
        public List<Article> GetAllArticle()
        {
            IEnumerable<Article> result = DbContext.Connection.Query<Article>("Article_Package.GetAllArticle", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Article> GetArticles()
        {
            IEnumerable<Article> result = DbContext.Connection.Query<Article>("Article_Package.GetArticles", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<PostInformationDTO> GetTopFiveArticle()
        {
            IEnumerable<PostInformationDTO> result = DbContext.Connection.Query<PostInformationDTO>("Article_Package.GetTopFiveArticle", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<PostInformationDTO> GetAllPostsNewInfo()
        {
            IEnumerable<PostInformationDTO> result = DbContext.Connection.Query<PostInformationDTO>("GetAllPostsNewInfo", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }  
        public List<PostInformationDTO> GetRecentPosts()
        {
            IEnumerable<PostInformationDTO> result = DbContext.Connection.Query<PostInformationDTO>("Article_Package.GetRecentPosts", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<CountOfArticleDTO> GetCountOfArticle()
        {
            IEnumerable<CountOfArticleDTO> result =  DbContext.Connection.Query<CountOfArticleDTO>("Article_Package.GetCountOfArticle",
                commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<GetCountOfCommenttDTO> GetCountOfCommentt(int id)
        {
            var p = new DynamicParameters();
            p.Add("@AId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<GetCountOfCommenttDTO> result = DbContext.Connection.Query<GetCountOfCommenttDTO>("Article_Package.GetCountOfCommentt",p,
                        commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<CountOfFavoriteDTO> GetCountOfFavorite(int id)
        {
            var p = new DynamicParameters();
            p.Add("@AId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<CountOfFavoriteDTO> result = DbContext.Connection.Query<CountOfFavoriteDTO>("Article_Package.GetCountOfFavorite",p,
                        commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<GetCountOfLikeDTO> GetCountOfLike(int id)
        {
            var p = new DynamicParameters();
            p.Add("@AId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<GetCountOfLikeDTO> result = DbContext.Connection.Query<GetCountOfLikeDTO>("Article_Package.GetCountOfLike",p,
                        commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateArticle(Article article)
        {
            var p = new DynamicParameters();
            p.Add("@AId", article.Id, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("@AArticleTitle", article.ArticleTitel, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@AArticleGrapgh", article.ArticleGrapgh, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@APublishDate", article.PublishDate, dbType: DbType.Date, ParameterDirection.Input);
            p.Add("@ACategoryId", article.CategoryId, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("@AArticleImage", article.ArticleImage, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@AUserId", article.UserId, dbType: DbType.Int32, ParameterDirection.Input);


            var result =DbContext.Connection.ExecuteAsync("Article_Package.UpdateArticle", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<PostInformationDTO> FillterArticleByCategory(int id)
        {
            var p = new DynamicParameters();
            p.Add("@cId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<PostInformationDTO> result = DbContext.Connection.Query<PostInformationDTO>("FillterArticleByCategory",p,
                        commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<PostInformationDTO> SearchArticle(Article article)
        {
            var p = new DynamicParameters();
            p.Add("@AArticleTitle", article.ArticleTitel, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<PostInformationDTO> result = DbContext.Connection.Query<PostInformationDTO>("SearchArticle", p,
                        commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Aouther> GetArticleAouther(int id)
        {
            var p = new DynamicParameters();
            p.Add("@AId", id, dbType: DbType.Int32, ParameterDirection.Input);
            IEnumerable<Aouther> result = DbContext.Connection.Query<Aouther>("Article_Package.GetArticleAouther", p,
                       commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<CommentInfo> GetArticleComments(int id) 
        {
            var p = new DynamicParameters();
            p.Add("@AId", id, dbType: DbType.Int32, ParameterDirection.Input);
            IEnumerable<CommentInfo> result = DbContext.Connection.Query<CommentInfo>("Article_Package.GetArticleComments", p,
                       commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Article> GetUserArticle(int id)
        {
            var p = new DynamicParameters();
            p.Add("@uId", id, dbType: DbType.Int32, ParameterDirection.Input);
            IEnumerable<Article> result = DbContext.Connection.Query<Article>("Article_Package.GetUserArticle", p,
                       commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<ArticleLikesDTO>GetArticleLikes(int id)
        {
            var p = new DynamicParameters();
            p.Add("@AId", id, dbType: DbType.Int32, ParameterDirection.Input);
            IEnumerable<ArticleLikesDTO> result = DbContext.Connection.Query<ArticleLikesDTO>("Article_Package.GetArticleLikes", p,
                       commandType: CommandType.StoredProcedure);
            return result.ToList();
        }


        public List<ReportDTO> ArticleReport()
        {
            IEnumerable<ReportDTO> result = DbContext.Connection.Query<ReportDTO>("GETREPORT", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool BlockArticle(int id)
        {
            var p = new DynamicParameters();
            p.Add("@aId", id, dbType: DbType.Int32, ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("Article_Package.BlockArticle",
                p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool UnBlockArticle(int id)
        {
            var p = new DynamicParameters();
            p.Add("@aId", id, dbType: DbType.Int32, ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("Article_Package.UnBlockArticle",
                p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool PublishArticle(int id)
        {
            var p = new DynamicParameters();
            p.Add("@AId", id, dbType: DbType.Int32, ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("Article_Package.PublishTheArticle",
                p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool CreateBlockedArticle(Article article)
        {
            var p = new DynamicParameters();
            p.Add("@AArticleTitle", article.ArticleTitel, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@AArticleGrapgh", article.ArticleGrapgh, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@APublishDate", article.PublishDate, dbType: DbType.Date, ParameterDirection.Input);
            p.Add("@ACategoryId", article.CategoryId, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("@AActiveStatus", article.ActiveStatus, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("@ABlockStatus", article.BlockStatus, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("@AArticleImage", article.ArticleImage, dbType: DbType.String, ParameterDirection.Input);



            var result = DbContext.Connection.ExecuteAsync("Article_Package.CreateBlockedArticle",
                p, commandType: CommandType.StoredProcedure);
            return true;
        }

    }
}
