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
    public class TasksRepository : ITasksRepository
    {
        private readonly IDBContext DBContext;
        public TasksRepository(IDBContext DBContext)
        {
            this.DBContext = DBContext;
        }
        public bool DeleteTasks(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("DeleteTasks", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Tasks> GetTasks()
        {
            IEnumerable<Tasks> Result = DBContext.Connection.Query<Tasks>("GetTasks", commandType: System.Data.CommandType.StoredProcedure);
            return Result.ToList();
        }

        public List<Tasks> GetTasksByAccountantId(int accountantId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@accountantId", accountantId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Tasks> Result = DBContext.Connection.Query<Tasks>("GetTasksByAccountantId", parameters, commandType: System.Data.CommandType.StoredProcedure);
            return Result.ToList();
        }

        public bool InsertTasks(Tasks Task)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@AccountantId", Task.AccountantId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@Task", Task.Task, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@IsDone", Task.IsDone, dbType: DbType.Int32, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("InsertTasks", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateTasks(Tasks Task)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", Task.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@AccountantId", Task.AccountantId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@Task", Task.Task, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@IsDone", Task.IsDone, dbType: DbType.Int32, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("UpdateTasks", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
