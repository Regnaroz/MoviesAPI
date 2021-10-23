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
    public class CheckInOutRepository : ICheckInOutRepository
    {
        private readonly IDBContext dBContext;
        public CheckInOutRepository(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public bool DeleteCheckInOut(int id)
        {
            var paramteres = new DynamicParameters();
            paramteres.Add("@Id", id, dbType: DbType.Int64, direction: ParameterDirection.Input);

            var Result = dBContext.Connection.ExecuteAsync("DeleteCheckInOut", paramteres, commandType: CommandType.StoredProcedure);

            return true;
        }

        public List<CheckInOut> GetCheckInOut()
        {
            IEnumerable<CheckInOut> Result = dBContext.Connection.Query<CheckInOut>("GetCheckInOut", commandType: CommandType.StoredProcedure);
            return Result.ToList();
        }

        public bool InsertCheckInOut(CheckInOut checkInOut)
        {
            var paramteres = new DynamicParameters();
            paramteres.Add("@accountantId", checkInOut.AccountantId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            paramteres.Add("@checkInTime", checkInOut.CheckInTime, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            paramteres.Add("@checkOutTime", checkInOut.CheckOutTime, dbType: DbType.DateTime, direction: ParameterDirection.Input);


            var Result = dBContext.Connection.ExecuteAsync("InsertCheckInOut", paramteres, commandType: CommandType.StoredProcedure);

            return true;
        }

        public bool UpdateCheckInOut(CheckInOut checkInOut)
        {
            var paramteres = new DynamicParameters();
            paramteres.Add("@Id", checkInOut.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            paramteres.Add("@accountantId", checkInOut.AccountantId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            paramteres.Add("@checkInTime", checkInOut.CheckInTime, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            paramteres.Add("@checkOutTime", checkInOut.CheckOutTime, dbType: DbType.DateTime, direction: ParameterDirection.Input);


            var Result = dBContext.Connection.ExecuteAsync("UpdateCheckInOut", paramteres, commandType: CommandType.StoredProcedure);

            return true;
        }
    }
}
