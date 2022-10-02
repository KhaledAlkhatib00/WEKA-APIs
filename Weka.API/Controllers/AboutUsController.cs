using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using Weka.Core.Data;
using Weka.Core.Service;

namespace Weka.API.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class AboutUsController : Controller
    {
        private readonly IAboutUsService aboutUsService;

        public AboutUsController (IAboutUsService aboutUsService)
        {
            this.aboutUsService = aboutUsService;
        }

        [HttpPost]
        public bool CreateAboutUs([FromBody]AboutUs aboutUs)
        {
            return aboutUsService.CreateAboutUs(aboutUs);
        }

        [HttpGet]
        public List<AboutUs> GetAllAboutUs()
        {
            return aboutUsService.GetAllAboutUs();
        }

        [HttpPut]
        public bool UpdateAboutUs([FromBody]AboutUs aboutUs)
        {
            return aboutUsService.UpdateAboutUs(aboutUs);
        }


        [HttpPost]
        public Article UploadImage()
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
                Article Item = new Article();
                Item.ArticleImage = attachmentFileName;
                return Item;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
