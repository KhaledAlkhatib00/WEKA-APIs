using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Weka.Core.Common;
using Weka.Core.Data;
using Weka.Core.Repository;

namespace Weka.Infra.Repository
{
    public class VisaInfoRepository : IVisaInfoRepository
    {
        private readonly IDbContext DbContext;
        public VisaInfoRepository(IDbContext _dbContext)
        {
            DbContext = _dbContext;
        }

        public bool CreateVisaInfo(VisaInfo visaInfo)
        {
            var p = new DynamicParameters();
            p.Add("@vNumber", visaInfo.VisaNumber, dbType: DbType.Int64, ParameterDirection.Input);
            p.Add("@vCV", visaInfo.CV, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("@vmm", visaInfo.mm, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("@vyy", visaInfo.yy, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("@vUserId", visaInfo.UserId, dbType: DbType.Int32, ParameterDirection.Input);

            var result = DbContext.Connection.ExecuteAsync("VisaInfo_Package.CreateVisaInfo", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteVisaInfo(int id)
        {
            var p = new DynamicParameters();
            p.Add("@vId", id, dbType: DbType.Int32, ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("VisaInfo_Package.DeleteVisaInfo", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<VisaInfo> GetAllVisaInfo()
        {
            IEnumerable<VisaInfo> result = DbContext.Connection.Query<VisaInfo>("VisaInfo_Package.GetAllVisaInfo",
                            commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool Payment(int id)
        {
            var p = new DynamicParameters();
            p.Add("@uId", id, dbType: DbType.Int32, ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("Payment", p, commandType: CommandType.StoredProcedure);
            return true;
        }

       
        public bool UpdateVisaInfo(VisaInfo visaInfo)
        {
            var p = new DynamicParameters();
            p.Add("@vId", visaInfo.Id, dbType: DbType.Int64, ParameterDirection.Input);
            p.Add("@vNumber", visaInfo.VisaNumber, dbType: DbType.Int64, ParameterDirection.Input);
            p.Add("@vCV", visaInfo.CV, dbType: DbType.Int64, ParameterDirection.Input);
            p.Add("@vmm", visaInfo.UserId, dbType: DbType.Int64, ParameterDirection.Input);
            p.Add("@vyy", visaInfo.UserId, dbType: DbType.Int64, ParameterDirection.Input);
            p.Add("@vUserId", visaInfo.UserId, dbType: DbType.Int64, ParameterDirection.Input);

            var result = DbContext.Connection.ExecuteAsync("VisaInfo_Package.UpdateVisaInfo", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
