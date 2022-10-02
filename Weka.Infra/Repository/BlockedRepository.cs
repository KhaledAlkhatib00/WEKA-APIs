using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Weka.Core.Common;
using Weka.Core.Data;
using Weka.Core.Repository;

namespace Weka.Infra.Repository
{
    public class BlockedRepository: IBlockedRepository
    {
        private readonly IDbContext DbContext;
        public BlockedRepository(IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }

        public bool CreateBlocked(Blocked blocked)
        {
            var p = new DynamicParameters();
            p.Add("@Id", blocked.BlockId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("Blocked_Package.CreateBlocked", p, commandType: CommandType.StoredProcedure);

            return true;
        }

        public bool DeleteBlocked(int id)
        {
            var p = new DynamicParameters();
            p.Add("@Id",id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("Blocked_Package.DeleteLikeArticle", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateBlocked(Blocked blocked)
        {
            var p = new DynamicParameters();
            p.Add("@Id", blocked.BlockId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("Blocked_Package.UpdateBlocked", p, commandType: CommandType.StoredProcedure);

            return true;
        }
    }
}
