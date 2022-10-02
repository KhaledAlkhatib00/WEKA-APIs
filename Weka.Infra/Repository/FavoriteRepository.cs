using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Weka.Core.Common;
using Weka.Core.Data;
using Weka.Core.Repository;

namespace Weka.Infra.Repository
{
    public class FavoriteRepository: IFavoriteRepository
    {
        private readonly IDbContext DbContext;
        public FavoriteRepository(IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }

        public bool CreateFavorite(Favorite favorite)
        {
            var p = new DynamicParameters();
            p.Add("@fUserId", favorite.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@fArticleId", favorite.ArticleId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("Favorite_Package.CreateFavorite", p, commandType: CommandType.StoredProcedure);

            return true;
        }

        public bool DeleteFavorite(int id, int uid)

        {
            var p = new DynamicParameters();
            p.Add("@fId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@uId", uid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("Favorite_Package.DeleteFavorite", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Favorite> GetAllFavorite()
        {
            IEnumerable<Favorite> result = DbContext.Connection.Query<Favorite>("Favorite_Package.GetAllFavorite", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
