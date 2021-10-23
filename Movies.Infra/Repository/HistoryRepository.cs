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
    public class HistoryRepository : IHistoryRepository
    {
        private readonly IDBContext DBContext;
        public HistoryRepository(IDBContext DBContext)
        {
            this.DBContext = DBContext;
        }
        public bool DeleteHistory(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("DeleteHistory", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<History> GetHistory()
        {
            IEnumerable<History> Result = DBContext.Connection.Query<History>("GetHistory", commandType: System.Data.CommandType.StoredProcedure);
            return Result.ToList();
        }

        public List<History> GetHistoryByCustomerId(int customerId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@customerId", customerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<History> Result = DBContext.Connection.Query<History>("GetHistoryByCustomerId", parameters, commandType: System.Data.CommandType.StoredProcedure);
            return Result.ToList();
        }

        public bool InsertHistory(History Histo)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@CustomerId", Histo.CustomerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@MovieId", Histo.MovieId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@Time", Histo.Time, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("InsertHistory", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateHistory(History Histo)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", Histo.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@CustomerId", Histo.CustomerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@MovieId", Histo.MovieId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@Time", Histo.Time, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("UpdateHistory", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
