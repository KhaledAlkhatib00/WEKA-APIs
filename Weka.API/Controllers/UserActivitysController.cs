using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Weka.Core.Data;
using Weka.Core.DTO;
using Weka.Core.Service;

namespace Weka.API.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class UserActivitysController : ControllerBase
    {
        private readonly IUserActivityService userActivityService;
        public UserActivitysController(IUserActivityService _userActivityService)
        {
            userActivityService = _userActivityService;
        }

        [HttpPost]
        public bool CreateUserActivity([FromBody] UserActivitys userActivitys)
        {
            return userActivityService.CreateUserActivity(userActivitys);
        }

        [HttpPost]
        [Route("{id}")]
        public List<UserActivityDTO> GetUserActivityLike(int id)
        {
            return userActivityService.GetUserActivityLike(id);
        }

    


    }
}
