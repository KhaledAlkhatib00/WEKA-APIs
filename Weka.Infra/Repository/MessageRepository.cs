using Dapper;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Weka.Core.Common;
using Weka.Core.Data;
using Weka.Core.Repository;
using Weka.Infra.Common;

namespace Weka.Infra.Repository
{
    public class MessageRepository : IMessageRepository
    {
        private readonly IDbContext DbContext;
        public MessageRepository(IDbContext _dbContext)
        {
            DbContext = _dbContext;
        }



        public bool CreateMessage(Message message)
        {
            var p = new DynamicParameters();
            p.Add("@mText", message.MessageText, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@mEmail", message.Email, dbType: DbType.String, ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("Message_Package.CreateMessage", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteMessage(int id)
        {
            var p = new DynamicParameters();
            p.Add("@mId",id, dbType: DbType.Int32, ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("Message_Package.DeleteMessage", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Message> GetAllMessage()
        {
            IEnumerable<Message> result = DbContext.Connection.Query<Message>("Message_Package.GetAllMessage", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
