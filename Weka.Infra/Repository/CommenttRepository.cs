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
    public class CommenttRepository : ICommenttRepository
    {

        private readonly IDbContext DbContext;
        public CommenttRepository(IDbContext _dbContext)
        {
            DbContext = _dbContext;
        }

        public bool CreateComments(Commentt commentt)
        {
            var p = new DynamicParameters();
            p.Add("@cText", commentt.CommentText, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@cDate", commentt.CommentDate, dbType: DbType.DateTime, ParameterDirection.Input);
            p.Add("@cArticleId", commentt.ArticleId, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("@cUserId", commentt.UserId, dbType: DbType.Int32, ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("Commentt_Package.CreateComments", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteComments(int id)
        {
            var p = new DynamicParameters();
            p.Add("@cId", id, dbType: DbType.String, ParameterDirection.Input);

            var result = DbContext.Connection.ExecuteAsync("Commentt_Package.DeleteComments", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Commentt> GetAllComments()
        {
            IEnumerable<Commentt> result = DbContext.Connection.Query<Commentt>("Commentt_Package.GetAllComments",
                           commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateComments(Commentt commentt)
        {
            var p = new DynamicParameters();
            p.Add("@cId", commentt.Id, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("@cText", commentt.CommentText, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@cDate", commentt.CommentDate, dbType: DbType.DateTime, ParameterDirection.Input);
            p.Add("@cArticleId", commentt.ArticleId, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("@cUserId", commentt.UserId, dbType: DbType.Int32, ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("Commentt_Package.UpdateComments", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public List<GetCountOfCommenttDTO> GetCountOfComment()
        {
            IEnumerable<GetCountOfCommenttDTO> result = DbContext.Connection.Query<GetCountOfCommenttDTO>("Commentt_Package.GetCountOfComment",
                           commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public List<GetCountOfCommenttDTO> GetCountOfFavorite()
        {
            IEnumerable<GetCountOfCommenttDTO> result = DbContext.Connection.Query<GetCountOfCommenttDTO>("Commentt_Package.GetCountOfFavorite",
                           commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
