using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;
using Weka.Core.DTO;
using Weka.Core.Repository;
using Weka.Core.Service;

namespace Weka.Infra.Service
{
    public class UserActivityService : IUserActivityService
    {
        private readonly IUserActivitysRopository userActivitysRopository;
        public UserActivityService(IUserActivitysRopository _userActivitysRopository)
        {
            userActivitysRopository =_userActivitysRopository;

        }
        public bool CreateUserActivity(UserActivitys userActivitys)
        {
           return userActivitysRopository.CreateUserActivity(userActivitys);
        }

      

        public List<UserActivityDTO> GetUserActivityLike(int id)
        {
            return userActivitysRopository.GetUserActivityLike(id);
        }
    }
}
