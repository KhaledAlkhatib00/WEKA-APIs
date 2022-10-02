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
    public class JWTRepository : IJWTRepository
    {
        private readonly IDbContext DbContext;
        public JWTRepository(IDbContext _dbContext)
        {
            DbContext = _dbContext;
        }




        public LoginDTO Auth(LoginDTO loginDTO)
        {
            var p = new DynamicParameters();
            p.Add("@uUserName", loginDTO.UserName, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@upass", loginDTO.Password, dbType: DbType.String, ParameterDirection.Input);
            IEnumerable<LoginDTO> result = DbContext.Connection.Query<LoginDTO>("User_Package.login", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }
    }
}
