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
    public class UserRepository : IUserRepository
    {

        private readonly IDbContext DbContext;
        public UserRepository(IDbContext _dbContext)
        {
            DbContext = _dbContext;
        }



        public bool BlockUser(int id)
        {
            var p = new DynamicParameters();
            p.Add("@uId", id, dbType: DbType.Int32, ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("User_Package.BlockUser", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool CreateUser(RegisterDTO register)
        {
            var p = new DynamicParameters();
            p.Add("@uFName", register.FName , dbType: DbType.String, ParameterDirection.Input);
            p.Add("@uLName", register.LName , dbType: DbType.String, ParameterDirection.Input);
            p.Add("@uEmail", register.Email , dbType: DbType.String, ParameterDirection.Input);
            p.Add("@uPhoneNumber", register.PhoneNumber , dbType: DbType.String, ParameterDirection.Input);
            p.Add("@uImage", register.UserImage , dbType: DbType.String, ParameterDirection.Input);
            p.Add("@uUserName", register.UserName , dbType: DbType.String, ParameterDirection.Input);
            p.Add("@uPass", register.Password , dbType: DbType.String, ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("User_Package.CreateUser", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteUser(int id)
        {
            var p = new DynamicParameters();
            p.Add("@uId",id, dbType: DbType.Int32, ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("User_Package.DeleteUser", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<User> GetAllUser()
        {
            IEnumerable<User> result = DbContext.Connection.Query<User>("User_Package.GetAllUser", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<UserDTO> GetNumberOfUsers()
        {
            IEnumerable<UserDTO> result = DbContext.Connection.Query<UserDTO>("User_Package.GetNumberOfUsers", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UnBlockUser(int id)
        {
            var p = new DynamicParameters();
            p.Add("@uId", id, dbType: DbType.Int32, ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("User_Package.UnBlockUser", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateUser(RegisterDTO register)
        {
            var p = new DynamicParameters();
            p.Add("@uId", register.UserId, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("@uFName", register.FName, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@uLName", register.LName, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@uEmail", register.Email, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@uPhoneNumber", register.PhoneNumber, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@uImage", register.UserImage, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@uUserName", register.UserName, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@uPass", register.Password, dbType: DbType.String, ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("User_Package.UpdateUser", p, commandType: CommandType.StoredProcedure);
            return true;
        }


        public bool UpdatePassword(PasswordDTO passwordDTO)
        {
            var p = new DynamicParameters();
            p.Add("@uId", passwordDTO.UserId, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("@oPass", passwordDTO.OldPassword, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@nPass", passwordDTO.NewPassword, dbType: DbType.String, ParameterDirection.Input);

            var result = DbContext.Connection.ExecuteAsync("User_Package.UpdatePassword", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<User> GetUserById(int id)
        {
            var p = new DynamicParameters();
            p.Add("@uId", id, dbType: DbType.Int32, ParameterDirection.Input);
            IEnumerable<User> result = DbContext.Connection.Query<User>("User_Package.GetUserById", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<UserVisaDTO> GetUserVisaInfo(int id)
        {
            var p = new DynamicParameters();
            p.Add("@uId", id, dbType: DbType.Int32, ParameterDirection.Input);
            IEnumerable<UserVisaDTO> result = DbContext.Connection.Query<UserVisaDTO>("User_Package.GetUserVisaInfo", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<UserEmailDTO> GetUserEmail(int id)
        {
            var p = new DynamicParameters();
            p.Add("@uId", id, dbType: DbType.Int32, ParameterDirection.Input);
            IEnumerable<UserEmailDTO> result = DbContext.Connection.Query<UserEmailDTO>("User_Package.GetUserEmail", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public List<Article> GetMyFavoriteArticle(int id)
        {

            var p = new DynamicParameters();
            p.Add("@uId", id, dbType: DbType.Int32, ParameterDirection.Input);
            IEnumerable<Article> result = DbContext.Connection.Query<Article>("User_Package.GetMyFavoriteArticle", p, commandType: CommandType.StoredProcedure);
            return result.ToList();

        }

    }
}
