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
    public class BadWordRepository : IBadWordRepository
    {
        private readonly IDbContext DbContext;
        public BadWordRepository(IDbContext _dbContext)
        {
            DbContext = _dbContext;
        }
        public bool CreateBadWord(BadWord badWord)
        {
            var p = new DynamicParameters();
            p.Add("@bWord", badWord.Word, dbType: DbType.String, ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("BadWord_Package.CreateBadWord",
                p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteBadWord(int id)
        {

            var p = new DynamicParameters();
            p.Add("@bId", id, dbType: DbType.Int32, ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("BadWord_Package.DeleteBadWord", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<BadWord> GetAllBadWord()
        {
            IEnumerable<BadWord> result = DbContext.Connection.Query<BadWord>("BadWord_Package.GetAllBadWord",
                commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateBadWord(BadWord badWord)
        {

            var p = new DynamicParameters();
            p.Add("@bId", badWord.Id, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("@bWord", badWord.Word, dbType: DbType.String, ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("BadWord_Package.UpdateBadWord", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
