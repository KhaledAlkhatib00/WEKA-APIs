using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;
using Weka.Core.Repository;
using Weka.Core.Service;

namespace Weka.Infra.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;
        public CategoryService(ICategoryRepository _categoryRepository)
        {
            categoryRepository = _categoryRepository;
        }
        public bool CreateCategory(Category category)
        {
            return categoryRepository.CreateCategory(category);
        }

        public bool DeleteCategory(int id)
        {
            return categoryRepository.DeleteCategory(id);
        }

        public List<Category> GetAllCategory()
        {
            return categoryRepository.GetAllCategory();
        }

        public bool UpdateCategory(Category category)
        {
            return categoryRepository.UpdateCategory(category);
        }
    }
}
