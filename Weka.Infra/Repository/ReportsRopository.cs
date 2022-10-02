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
    public class ReportsRopository : IReportsRopository


    {
        private readonly IDbContext DbContext;
        public ReportsRopository(IDbContext _dbContext)
        {
            DbContext = _dbContext;
        }

        public bool CreateReports(Reports reports)
        {
            var p = new DynamicParameters();
            p.Add("@rMessage", reports.ReportMessage, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@rDate", reports.ReportDate, dbType: DbType.DateTime, ParameterDirection.Input);
            p.Add("@rUserId", reports.UserId, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("@rArticleId", reports.ArticleId, dbType: DbType.Int32, ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("Reports_Package.CreateReports"
                , p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteReports(int id)
        {
            var p = new DynamicParameters();
            p.Add("@rId",id, dbType: DbType.Int32, ParameterDirection.Input);
          
            var result = DbContext.Connection.ExecuteAsync("Reports_Package.DeleteReports", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<AllReportsInfoDTO> GetAllReports()
        {

            IEnumerable<AllReportsInfoDTO> result = DbContext.Connection.Query<AllReportsInfoDTO>("Reports_Package.GetAllReportsInfo", 
                commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateReports(Reports reports)
        {
            var p = new DynamicParameters();
            p.Add("@rId", reports.Id, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("@rMessage", reports.ReportMessage, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@rDate", reports.ReportDate, dbType: DbType.DateTime, ParameterDirection.Input);
            p.Add("@rUserId", reports.UserId, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("@rArticleId", reports.ArticleId, dbType: DbType.Int32, ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("Reports_Package.UpdateReports", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
