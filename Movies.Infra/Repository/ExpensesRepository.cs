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
    public class ExpensesRepository : IExpensesRepository
    {
        private readonly IDBContext DBContext;
        public ExpensesRepository(IDBContext DBContext)
        {
            this.DBContext = DBContext;
        }
        public bool DeleteExpenses(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("DeleteExpenses", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Expenses> GetExpenses()
        {
            IEnumerable<Expenses> Result = DBContext.Connection.Query<Expenses>("GetExpenses", commandType: System.Data.CommandType.StoredProcedure);
            return Result.ToList();
        }

        public bool InsertExpenses(Expenses Expense)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@accountantId", Expense.AccountantId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@Value", Expense.Value, dbType: DbType.Double, direction: ParameterDirection.Input);
            parameters.Add("@Time", Expense.Time, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("InsertExpenses", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateExpenses(Expenses Expense)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", Expense.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@accountantId", Expense.AccountantId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@Value", Expense.Value, dbType: DbType.Double, direction: ParameterDirection.Input);
            parameters.Add("@Time", Expense.Time, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("UpdateExpenses", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
        public IEnumerable<double> SumOfExpenses()
        {
            IEnumerable<double> Result = DBContext.Connection.Query<double>("SumOfExpenses", commandType: CommandType.StoredProcedure);
            return Result;
        }
    }
}
