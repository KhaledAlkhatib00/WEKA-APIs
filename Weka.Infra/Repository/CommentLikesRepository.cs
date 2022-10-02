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
    public class CommentLikesRepository: ICommentLikesRepository
    {
        private readonly IDbContext DbContext;
        public CommentLikesRepository (IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }

        public bool CreateCommentLikes(CommentLikes commentLikes)
        {
            var p = new DynamicParameters();
            p.Add("@cId", commentLikes.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("CommentLikes_Package.CreateCommentLikes", p, commandType: CommandType.StoredProcedure);

            return true;
        }

        public bool DeleteCommentLikes(int id)
        {
            var p = new DynamicParameters();
            p.Add("@cId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("CommentLikes.DeleteCommentLikes", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<GetCountOfLikeDTO> GetCommentLike(int id)
        {
            var p = new DynamicParameters();
            p.Add("@cId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<GetCountOfLikeDTO> result = DbContext.Connection.Query<GetCountOfLikeDTO>("Commentt_Package.GetCommentLike", p,
                        commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateCommentLikes(CommentLikes commentLikes)
        {
            var p = new DynamicParameters();
            p.Add("@cId", commentLikes.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("CommentLikes.UpdateCommentLikes", p, commandType: CommandType.StoredProcedure);

            return true;
        }
    }
}
