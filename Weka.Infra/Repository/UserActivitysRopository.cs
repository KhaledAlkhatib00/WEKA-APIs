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
    public class UserActivitysRopository : IUserActivitysRopository
    {
        private readonly IDbContext DbContext;
        public UserActivitysRopository(IDbContext _dbContext)
        {
            DbContext = _dbContext;
        }
        public bool CreateUserActivity(UserActivitys userActivitys)
        {
            var p = new DynamicParameters();
            p.Add("@AAText", userActivitys.ActivityText, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@ActivityId", userActivitys.atctivityId, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("@aUserId", userActivitys.UserId, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("@aArticleId", userActivitys.ArticleId, dbType: DbType.Int32, ParameterDirection.Input);
           
            var result = DbContext.Connection.ExecuteAsync("CreateUserActivity",
                p, commandType: CommandType.StoredProcedure);
            return true;
        }

     
        public List<UserActivityDTO> GetUserActivityLike(int id)
        {
          
                var p = new DynamicParameters();
                p.Add("@uId", id, dbType: DbType.Int32, ParameterDirection.Input);
                IEnumerable<UserActivityDTO> result = DbContext.Connection.Query<UserActivityDTO>("GetUserActivityLike", p,
                           commandType: CommandType.StoredProcedure);
                return result.ToList();
          
        }
    }
}
