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
    public class CustomerListRepository : ICustomerListRepository
    {
        private readonly IDBContext DBContext;
        public CustomerListRepository(IDBContext DBContext)
        {
            this.DBContext = DBContext;
        }
        public bool DeleteCustomerList(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("DeleteCustomerList", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<CustomerList> GetCustomerList()
        {
            IEnumerable<CustomerList> Result = DBContext.Connection.Query<CustomerList>("GetCustomerList", commandType: System.Data.CommandType.StoredProcedure);
            return Result.ToList();
        }

        public bool InsertCustomerList(CustomerList CustomerList)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@MovieId", CustomerList.MovieId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@CustomerId", CustomerList.CustomerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@Watched", CustomerList.Watched, dbType: DbType.Int32, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("InsertCustomerList", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateCustomerList(CustomerList CustomerList)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", CustomerList.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@MovieId", CustomerList.MovieId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@CustomerId", CustomerList.CustomerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@Watched", CustomerList.Watched, dbType: DbType.Int32, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("UpdateCustomerList", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
