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
    public class WorkingHoursRepository : IWorkingHoursRepository
    {
        private readonly IDBContext DBContext;
        public WorkingHoursRepository(IDBContext DBContext)
        {
            this.DBContext = DBContext;
        }
        public bool DeleteWorkingHours(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("DeleteWorkingHours", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<WorkingHours> GetWorkingHours()
        {
            IEnumerable<WorkingHours> Result = DBContext.Connection.Query<WorkingHours>("GetWorkingHours", commandType: System.Data.CommandType.StoredProcedure);
            return Result.ToList();
        }

        public bool InsertWorkingHours(WorkingHours WorkingHours)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@AccountantId", WorkingHours.AccountantId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@Date", WorkingHours.Date, dbType: DbType.Date, direction: ParameterDirection.Input);
            parameters.Add("@Hours", WorkingHours.Hours, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@Minutes", WorkingHours.Minutes, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@Seconds", WorkingHours.Seconds, dbType: DbType.Int32, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("InsertWorkingHours", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateWorkingHours(WorkingHours WorkingHours)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", WorkingHours.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@AccountantId", WorkingHours.AccountantId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@Date", WorkingHours.Date, dbType: DbType.Date, direction: ParameterDirection.Input);
            parameters.Add("@Hours", WorkingHours.Hours, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@Minutes", WorkingHours.Minutes, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@Seconds", WorkingHours.Seconds, dbType: DbType.Int32, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("UpdateWorkingHours", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
    }

