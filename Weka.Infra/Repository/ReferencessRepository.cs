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
    public class ReferencessRepository : IReferencessRepository
    {
        private readonly IDbContext DbContext;
        public ReferencessRepository(IDbContext _dbContext)
        {
            DbContext = _dbContext;
        }


        public bool CreateReferences(Referencess referencess)
        {
            var p = new DynamicParameters();
            p.Add("@rName", referencess.ReffName, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@rLink", referencess.ReffLink, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@rArticleId", referencess.ArticleId, dbType: DbType.Int32, ParameterDirection.Input);

            var result = DbContext.Connection.ExecuteAsync("References_Package.CreateReferences", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteReferences(int id)
        {
            var p = new DynamicParameters();
            p.Add("@rId", id, dbType: DbType.Int32, ParameterDirection.Input);
          
            var result = DbContext.Connection.ExecuteAsync("References_Package.DeleteReferences", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Referencess> GetAllReferences()
        {
            IEnumerable<Referencess> result = DbContext.Connection.Query<Referencess>("References_Package.GetAllReferences",
                            commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateReferences(Referencess referencess)
        {
            var p = new DynamicParameters();
            p.Add("@rId", referencess.Id, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("@rName", referencess.ReffName, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@rLink", referencess.ReffLink, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@rArticleId", referencess.ArticleId, dbType: DbType.Int32, ParameterDirection.Input);

            var result = DbContext.Connection.ExecuteAsync("References_Package.UpdateReferences", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
