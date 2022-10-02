using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Weka.Core.Common;
using Weka.Core.Data;
using Weka.Core.Repository;

namespace Weka.Infra.Repository
{
    public class CategoryRepository : ICategoryRepository
    {

        private readonly IDbContext DbContext;
        public CategoryRepository(IDbContext _dbContext)
        {
            DbContext = _dbContext;
        }

        public bool CreateCategory(Category category)
        {
            var p = new DynamicParameters();
            p.Add("@catName", category.CategoryName, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@catImage", category.CategoryImage, dbType: DbType.String, ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("Category_Package.CreateCategory", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteCategory(int id)
        {
            var p = new DynamicParameters();
            p.Add("@catId", id, dbType: DbType.Int32, ParameterDirection.Input);
          var result = DbContext.Connection.ExecuteAsync("Category_Package.DeleteCategory", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Category> GetAllCategory()
        {
            IEnumerable<Category> result = DbContext.Connection.Query<Category>("Category_Package.GetAllCategory",
                        commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateCategory(Category category)
        {
            var p = new DynamicParameters();
            p.Add("@catId", category.Id, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("@catName", category.CategoryName, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@catImage", category.CategoryImage, dbType: DbType.String, ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("Category_Package.UpdateCategory", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
