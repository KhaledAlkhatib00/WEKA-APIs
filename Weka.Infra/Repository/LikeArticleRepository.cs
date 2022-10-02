using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Weka.Core.Common;
using Weka.Core.Data;
using Weka.Core.DTO;
using Weka.Core.Repository;

namespace Weka.Infra.Repository
{
    public class LikeArticleRepository : ILikeArticleRepository
    {
        private readonly IDbContext DbContext;
        public LikeArticleRepository(IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }

        public bool BlockArticle(int id)
        {
            var p = new DynamicParameters();
            p.Add("@aId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("Article_Package.blockArticle", p, commandType: CommandType.StoredProcedure);

            return true;
        }


        public List<LikeArticle> GetAllLikes()
        {
            IEnumerable<LikeArticle> result = DbContext.Connection.Query<LikeArticle>("LikeArticlePackage.GetAllLikes",
                 commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool CreateLike(LikeArticle likeArticle)
        {
            var p = new DynamicParameters();
            p.Add("@AUserId", likeArticle.UserId, dbType: DbType.Int32,direction: ParameterDirection.Input);
            p.Add("@AArticleId", likeArticle.ArticleId, dbType: DbType.Int32,direction: ParameterDirection.Input);
            var result =DbContext.Connection.ExecuteAsync("LikeArticlePackage.CreateLike", p, commandType: CommandType.StoredProcedure); 
            
            return true;

        }

        public bool DeleteLike(int id)
        {
            var p = new DynamicParameters();
            p.Add("@Lid", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("LikeArticlePackage.DeleteLike", p, commandType: CommandType.StoredProcedure); 
            return true;
        }


        public List<GetTheProfetDTO> GetTheProfet()
        {
            IEnumerable<GetTheProfetDTO> result = DbContext.Connection.Query<GetTheProfetDTO>("Article_Package.GetTheProfet",
                commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<GetTheLossesDTO> GetTheLosses()
        {
            IEnumerable<GetTheLossesDTO> result = DbContext.Connection.Query<GetTheLossesDTO>("Article_Package.GetTheLosses",
                           commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool PublishTheArticle(int id)
        {
            var p = new DynamicParameters();
            p.Add("@aId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("Article_Package.PublishTheArticle", p, commandType: CommandType.StoredProcedure);

            return true;
        }

        public bool UnBlockArticle(int id)
        {
            var p = new DynamicParameters();
            p.Add("@aId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("Article_Package.unblockArticle", p, commandType: CommandType.StoredProcedure);

            return true;
        }

        public bool UpdateLikeArticle(LikeArticle likeArticle)
        {
            var p = new DynamicParameters();
            p.Add("@Id", likeArticle.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("Article_Package.UpdateLikeArticle", p, commandType: CommandType.StoredProcedure);

            return true;
        }
    }
}
