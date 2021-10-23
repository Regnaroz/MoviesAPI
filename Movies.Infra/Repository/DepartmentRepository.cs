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
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly IDBContext DBContext;
        public DepartmentRepository(IDBContext DBContext)
        {
            this.DBContext = DBContext;
        }
        public bool DeleteDepartment(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("DeleteDepartment", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Department> GetDepartment()
        {
            IEnumerable<Department> Result = DBContext.Connection.Query<Department>("GetDepartment", commandType: System.Data.CommandType.StoredProcedure);
            return Result.ToList();
        }

        public bool InsertDepartment(Department Department)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Name", Department.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("InsertDepartment", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateDepartment(Department Department)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", Department.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@Name", Department.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("UpdateDepartment", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
