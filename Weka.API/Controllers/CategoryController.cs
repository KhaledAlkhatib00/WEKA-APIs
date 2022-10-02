using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Weka.Core.Data;
using Weka.Core.Service;

namespace Weka.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;
        public CategoryController(ICategoryService _categoryService)
        {
            categoryService = _categoryService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Category>), StatusCodes.Status200OK)]
        public List<Category> GetAllCategory()
        {
            return categoryService.GetAllCategory();
        }


        [HttpPost]
        [ProducesResponseType(typeof(Category), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateCategory([FromBody] Category category)
        {
            return categoryService.CreateCategory(category);
        }


        [HttpPut]
        [ProducesResponseType(typeof(Category), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateCategory([FromBody] Category category)
        {
            return categoryService.UpdateCategory(category);
        }

        [HttpDelete]
        [ProducesResponseType(typeof(Category), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("delete/{id}")]
        public bool DeleteCategory(int id)
        {
            return categoryService.DeleteCategory(id);
        }


        [HttpPost]
        public Category UploadImage()
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
                Category item = new Category();
                item.CategoryImage = attachmentFileName;
                return item;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
