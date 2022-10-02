using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Dapper;
using Weka.Core.Common;
using Weka.Core.Data;
using Weka.Core.DTO;
using Weka.Core.IRepository;

namespace Weka.Infra.Repository
{
    public class TestamonialRepository: ITestamonialRepository
    {
        private readonly IDbContext DbContext;
        public TestamonialRepository(IDbContext _dbContext)
        {
            DbContext = _dbContext;
        }

        public bool CreateTestamonial(Testamoniall testamonial)
        {


            var p = new DynamicParameters();
            p.Add("@TMessageText", testamonial.MessageText, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@TRate", testamonial.Rate, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("@TUserId", testamonial.UserId, dbType: DbType.Int32, ParameterDirection.Input);



            var result = DbContext.Connection.ExecuteAsync("Testamonial_Package.CreateTestamonial",
                p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<homeTestimonial> GetTestimonialForm()
        {
            IEnumerable<homeTestimonial> result = DbContext.Connection.Query<homeTestimonial>("Testamonial_Package.GetTestimonialForm", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool DeleteTestamonial(int id)
        {
        var p = new DynamicParameters();
        p.Add("@TId", id, dbType: DbType.Int32, ParameterDirection.Input);
        var result = DbContext.Connection.ExecuteAsync("Testamonial_Package.DeleteTestamonial",
            p, commandType: CommandType.StoredProcedure);
        return true;
    }

        public List<TestimonialDTO> GetAllTestamonial()
        {
            IEnumerable<TestimonialDTO> result = DbContext.Connection.Query<TestimonialDTO>("Testamonial_Package.GetAllTestamonial", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateTestamonial(Testamoniall testamonial)
        {

            var p = new DynamicParameters();
            p.Add("@TId", testamonial.Id, dbType: DbType.Int32,direction: ParameterDirection.Input);
            p.Add("@TMessageText", testamonial.MessageText, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@TRate", testamonial.Rate, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("@TUserId", testamonial.UserId, dbType: DbType.Int32, ParameterDirection.Input);

            var result =
                DbContext.Connection.ExecuteAsync("Testamonial_Package.UpdateTestamonial", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool ShowTestimonial(int id)
        {
            var p = new DynamicParameters();
            p.Add("@tId", id, dbType: DbType.Int32, ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("Testamonial_Package.ShowTestimonial",
                p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool HideTestimonial(int id)
        {
            var p = new DynamicParameters();
            p.Add("@tId", id, dbType: DbType.Int32, ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("Testamonial_Package.HideTestimonial",
                p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
