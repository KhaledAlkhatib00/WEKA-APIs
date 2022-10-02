using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;

namespace Weka.Core.Repository
{
    public interface ICategoryRepository
    {
        bool CreateCategory(Category category);
        bool UpdateCategory(Category category);
        List<Category> GetAllCategory();
        bool DeleteCategory(int id);
    }
}
