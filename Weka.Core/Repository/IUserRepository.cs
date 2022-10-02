﻿using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;
using Weka.Core.DTO;

namespace Weka.Core.Repository
{
    public interface IUserRepository
    {
        bool CreateUser(RegisterDTO register);
        bool UpdateUser(RegisterDTO register);
        List<User> GetAllUser();
        bool DeleteUser(int id);
        bool BlockUser(int id);
        bool UnBlockUser(int id);
        List<UserDTO> GetNumberOfUsers();
        bool UpdatePassword(PasswordDTO passwordDTO);
        List<User> GetUserById(int id);
        List<UserEmailDTO> GetUserEmail(int id);
        List<Article> GetMyFavoriteArticle(int id);
        List<UserVisaDTO> GetUserVisaInfo(int id);

    }
}
