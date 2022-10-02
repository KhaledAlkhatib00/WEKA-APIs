using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using Weka.Core.Data;
using Weka.Core.DTO;
using Weka.Core.Service;

namespace Weka.API.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }


        [HttpPost]
        public bool CreateUser([FromBody] RegisterDTO register)
        {
            return userService.CreateUser(register);
        }



        [HttpPut]
        public bool UpdateUser([FromBody] RegisterDTO register)
        {
            return userService.UpdateUser(register);
        }

        [HttpGet]
        public List<User> GetAllUser()
        {
            return userService.GetAllUser();
        }



        [HttpDelete]
        [Route("{id}")]
        public bool DeleteUser(int id)
        {
            return userService.DeleteUser(id);
        }


        [HttpGet]
        [Route("{id}")]
        public bool BlockUser(int id)
        {
            return userService.BlockUser(id);
        }



        [HttpGet]
        [Route("{id}")]
        public bool UnBlockUser(int id)
        {
            return userService.UnBlockUser(id);
        }


        [HttpGet]
        public List<UserDTO> GetNumberOfUsers()
        {
            return userService.GetNumberOfUsers();
        }

        [HttpPost]
        public RegisterDTO UploadImage()
        {
            try
            {
                var file = Request.Form.Files[0];
                byte[] fileContant;
                using (var ms = new MemoryStream())
                {
                    file.CopyTo(ms);
                    fileContant = ms.ToArray();
                }
                var fileName = Path.GetFileNameWithoutExtension(file.FileName);
                string attachmentFileName = $"{fileName}.{Path.GetExtension(file.FileName).Replace(".", "")}";
                var fullPath = Path.Combine("D:\\wekav2\\weka\\src\\assets\\Images\\", attachmentFileName);
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                RegisterDTO item = new RegisterDTO();
                item.UserImage = attachmentFileName;
                return item;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        [HttpPost]
        public bool UpdatePassword([FromBody] PasswordDTO passwordDTO)
        {
            return userService.UpdatePassword(passwordDTO);
        }

        [HttpGet]
        [Route("{id}")]
        public List<User> GetUserById(int id)
        {
            return userService.GetUserById(id);
        }

        [HttpPost]
        [Route("{id}")]
        public List<UserEmailDTO> GetUserEmail(int id)
        {
            return userService.GetUserEmail(id);
        }
        [HttpPost]
        [Route("{id}")]
        public List<Article> GetMyFavoriteArticle(int id)
        {
            return userService.GetMyFavoriteArticle(id);
        }
        [HttpPost]
        [Route("{id}")]
        public List<UserVisaDTO> GetUserVisaInfo(int id)
        {
            return userService.GetUserVisaInfo(id);
        }
    }
}
