using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;
using Weka.Core.DTO;

namespace Weka.Core.Repository
{
    public interface IUserActivitysRopository
    {
        public bool CreateUserActivity(UserActivitys userActivitys);
        public List<UserActivityDTO> GetUserActivityLike(int id);
       
    }
}
