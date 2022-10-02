using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Dapper;
using Weka.Core.Common;
using Weka.Core.Data;
using Weka.Core.IRepository;

namespace Weka.Infra.Repository
{
    public class HomeRepository : IHomeRepository
    {

        private readonly IDbContext DbContext;
        public HomeRepository(IDbContext _dbContext)
        {
            DbContext = _dbContext;
        }

        public bool CreateHome(Home home)
        {
            var p = new DynamicParameters();
            p.Add("@HText1", home.Text1, dbType: DbType.String, direction:ParameterDirection.Input);
            p.Add("@HText2", home.Text2, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@HText3", home.Text3, dbType: DbType.String, direction:ParameterDirection.Input);
            p.Add("@HText4", home.Text4, dbType: DbType.String, direction:ParameterDirection.Input);
            p.Add("@HImage1", home.Image1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@HImage2", home.Image2, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@HImage3", home.Image3, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@HImage4", home.Image4, dbType: DbType.String, direction: ParameterDirection.Input);


            var result = DbContext.Connection.ExecuteAsync("Home_Package.CreateHome",
                p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteHome(int id)
        {
            var p = new DynamicParameters();
            p.Add("@HId", id, dbType: DbType.Int32, ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("Home_Package.DeleteHome",
                p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Home> GetAllHome()
        {
            IEnumerable<Home> result = DbContext.Connection.Query<Home>("Home_Package.GetAllHome", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateHome(Home home)
        {
            
                var p = new DynamicParameters();
                p.Add("@HId", home.Id, dbType: DbType.Int32,
                direction: ParameterDirection.Input);
                p.Add("@HText1", home.Text1, dbType: DbType.String, direction: ParameterDirection.Input);
                p.Add("@HText2", home.Text2, dbType: DbType.String, direction: ParameterDirection.Input);
                p.Add("@HText3", home.Text3, dbType: DbType.String, direction: ParameterDirection.Input);
                p.Add("@HText4", home.Text4, dbType: DbType.String, direction: ParameterDirection.Input);
                p.Add("@HImage1", home.Image1, dbType: DbType.String, direction: ParameterDirection.Input);
                p.Add("@HImage2", home.Image2, dbType: DbType.String, direction: ParameterDirection.Input);
                p.Add("@HImage3", home.Image3, dbType: DbType.String, direction: ParameterDirection.Input);
                p.Add("@HImage4", home.Image4, dbType: DbType.String, direction: ParameterDirection.Input);

            var result =
                DbContext.Connection.ExecuteAsync("Home_Package.UpdateHome", p, commandType: CommandType.StoredProcedure);
                return true;
            }
        }
    }
