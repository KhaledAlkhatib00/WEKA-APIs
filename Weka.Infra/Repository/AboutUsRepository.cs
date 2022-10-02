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
    public class AboutUsRepository : IAboutUsRepository
    {
        private readonly IDbContext DbContext;
        public AboutUsRepository(IDbContext _dbContext)
        {
            DbContext = _dbContext;
        }




        public bool CreateAboutUs(AboutUs aboutUs)
        {
            var p = new DynamicParameters();
            p.Add("@aText", aboutUs.AboutText, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@aTitle", aboutUs.Title, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@aLocation", aboutUs.LocationPath, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@aImage", aboutUs.Image, dbType: DbType.String, ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("AboutUs_Package.CreateAboutUs", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<AboutUs> GetAllAboutUs()
        {
            IEnumerable<AboutUs> result = DbContext.Connection.Query<AboutUs>("AboutUs_Package.GetAllAboutUs", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateAboutUs(AboutUs aboutUs)
        {
            var p = new DynamicParameters();
            p.Add("@aId", aboutUs.Id, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@aText", aboutUs.AboutText, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@aTitle", aboutUs.Title, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@aLocation", aboutUs.LocationPath, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@aImage", aboutUs.Image, dbType: DbType.String, ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("AboutUs_Package.UpdateAboutUs", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
