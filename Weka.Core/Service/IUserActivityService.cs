using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;
using Weka.Core.DTO;

namespace Weka.Core.Service
{
    public interface IUserActivityService
    {
        public bool CreateUserActivity(UserActivitys userActivitys);
        public List<UserActivityDTO> GetUserActivityLike(int id);
    }
}
