using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Weka.Core.Data;
using Weka.Core.Service;

namespace Weka.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        private readonly IHomeService homeService;
        public HomeController(IHomeService _homeService)
        {
            homeService = _homeService;
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<Home>), StatusCodes.Status200OK)]
        public List<Home> GetAllHome()
        {
            return homeService.GetAllHome();
        }
        [HttpPost]
        [ProducesResponseType(typeof(Home), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateHome([FromBody] Home home)
        {
            return homeService.CreateHome(home);
        }

        [HttpPut]
        [ProducesResponseType(typeof(List<Home>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateHome([FromBody] Home home)
        {
            return homeService.UpdateHome(home);
        }
        [HttpDelete]
        [Route("delete/{id}")]
        public bool DeleteHome(int id)
        {
            return homeService.DeleteHome(id);
        }

        [HttpPost]
        [Route("UploadImage")]
        public Home UploadImage()
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
                Home item = new Home();
                item.Image1 = attachmentFileName;
                return item;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
