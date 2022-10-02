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
    public class ContactUsRepository : IContactUsRepository
    {

        private readonly IDbContext DbContext;
        public ContactUsRepository(IDbContext _dbContext)
        {
            DbContext = _dbContext;
        }
        public bool CreateContactUs(ContactUs contactUs)
        {
            var p = new DynamicParameters();
            p.Add("@CSubject", contactUs.Subject, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@CMessageText", contactUs.MessageText, dbType: DbType.String, ParameterDirection.Input);



            var result = DbContext.Connection.ExecuteAsync("ContactUs_Package.CreateContactUs",
                p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteContactUs(int id)
        {
            var p = new DynamicParameters();
            p.Add("@CId", id, dbType: DbType.Int32, ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("ContactUs_Package.DeleteContactUs",
                p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<ContactUs> GetAllContactUs()
        {
            IEnumerable<ContactUs> result = DbContext.Connection.Query<ContactUs>("ContactUs_Package.GetAllContactUs", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateContactUs(ContactUs contactUs)
        {
            var p = new DynamicParameters();
            p.Add("@CId", contactUs.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CSubject", contactUs.Subject, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@CMessageText", contactUs.MessageText, dbType: DbType.String, ParameterDirection.Input);
            var result =
                DbContext.Connection.ExecuteAsync("ContactUs_Package.UpdateContactUs", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
