using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;
using Weka.Core.DTO;

namespace Weka.Core.Service
{
    public interface IUserService
    {
        bool CreateUser(RegisterDTO register);
        bool UpdateUser(RegisterDTO register);
        List<User> GetAllUser();
        List<UserEmailDTO> GetUserEmail(int id);
        List<Article> GetMyFavoriteArticle(int id);

        bool DeleteUser(int id);
        bool BlockUser(int id);
        bool UnBlockUser(int id);
        List<UserDTO> GetNumberOfUsers();
        bool UpdatePassword(PasswordDTO passwordDTO);
        List<User> GetUserById(int id);
        List<UserVisaDTO> GetUserVisaInfo(int id);
    }
}
