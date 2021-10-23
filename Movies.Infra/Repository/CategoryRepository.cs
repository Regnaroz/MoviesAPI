using Dapper;
using Movies.Core.Common;
using Movies.Core.Data;
using Movies.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Movies.Infra.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IDBContext dBContext;
        public CategoryRepository(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public bool DeleteCategory(int id)
        {
            var paramteres = new DynamicParameters();
            paramteres.Add("@Id", id, dbType: DbType.Int64, direction: ParameterDirection.Input);

            var Result = dBContext.Connection.ExecuteAsync("DeleteCategory", paramteres, commandType: CommandType.StoredProcedure);

            return true;
        }

        public List<Category> GetCategory()
        {
            IEnumerable<Category> Result = dBContext.Connection.Query<Category>("GetCategory", commandType: CommandType.StoredProcedure);
            return Result.ToList();
        }

        public bool InsertCategory(Category category)
        {
            var paramteres = new DynamicParameters();
            paramteres.Add("@name", category.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            

            var Result = dBContext.Connection.ExecuteAsync("InsertCategory", paramteres, commandType: CommandType.StoredProcedure);

            return true;
        }

        public bool UpdateCategory(Category category)
        {
            var paramteres = new DynamicParameters();
            paramteres.Add("@Id", category.Id, dbType: DbType.String, direction: ParameterDirection.Input);
            paramteres.Add("@name", category.Name, dbType: DbType.String, direction: ParameterDirection.Input);


            var Result = dBContext.Connection.ExecuteAsync("InsertCategory", paramteres, commandType: CommandType.StoredProcedure);

            return true;
        }
    }
}
