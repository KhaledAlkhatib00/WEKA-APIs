using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;
using Weka.Core.DTO;
using Weka.Core.Repository;
using Weka.Core.Service;

namespace Weka.Infra.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public bool BlockUser(int id)
        {
            return _userRepository.BlockUser(id);
        }

        public bool CreateUser(RegisterDTO register)
        {
            return _userRepository.CreateUser(register);
        }

        public bool DeleteUser(int id)
        {
            return _userRepository.DeleteUser(id);
        }

        public List<User> GetAllUser()
        {
            return _userRepository.GetAllUser();
        }

        public List<UserDTO> GetNumberOfUsers()
        {
            return _userRepository.GetNumberOfUsers();
        }

        public bool UnBlockUser(int id)
        {
            return _userRepository.UnBlockUser(id);
        }

        public bool UpdateUser(RegisterDTO register)
        {
            return _userRepository.UpdateUser(register);
        }

        public bool UpdatePassword(PasswordDTO passwordDTO)
        {
            return _userRepository.UpdatePassword(passwordDTO);
        }

        public List<User> GetUserById(int id)
        {
            return _userRepository.GetUserById(id);
        }
        public List<UserVisaDTO> GetUserVisaInfo(int id)
        {
            return _userRepository.GetUserVisaInfo(id);
        }

        public List<UserEmailDTO> GetUserEmail(int id)
        {
            return _userRepository.GetUserEmail(id);
        }

        public List<Article> GetMyFavoriteArticle(int id)
        {
            return _userRepository.GetMyFavoriteArticle(id);
        }
    }
}
