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
    public class MessengerRepository : IMessengerRepository
    {
        private readonly IDBContext DBContext;
        public MessengerRepository(IDBContext DBContext)
        {
            this.DBContext = DBContext;
        }
        public bool DeleteMessenger(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("DeleteMessenger", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Messenger> GetMessenger()
        {
            IEnumerable<Messenger> Result = DBContext.Connection.Query<Messenger>("GetMessenger", commandType: System.Data.CommandType.StoredProcedure);
            return Result.ToList();
        }

        public List<Messenger> GetMessengerByCustomerId(int customerId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@customerId", customerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Messenger> Result = DBContext.Connection.Query<Messenger>("GetMessengerByCustomerId", parameters, commandType: System.Data.CommandType.StoredProcedure);
            return Result.ToList();
        }

        public bool InsertMessenger(Messenger Messenger)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@CustomerId", Messenger.CustomerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@AccountantId", Messenger.AccountantId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@CustomerMeassage", Messenger.CustomerMeassage, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@AccountantMessage", Messenger.AccountantMessage, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Time", Messenger.Time, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("InsertMessenger", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateMessenger(Messenger Messenger)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", Messenger.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@CustomerId", Messenger.CustomerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@AccountantId", Messenger.AccountantId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@CustomerMeassage", Messenger.CustomerMeassage, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@AccountantMessage", Messenger.AccountantMessage, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Time", Messenger.Time, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("UpdateMessenger", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
