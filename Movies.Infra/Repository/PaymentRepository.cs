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
    public class PaymentRepository: IPaymentRepository
    {
        private readonly IDBContext DBContext;
        public PaymentRepository(IDBContext DBContext)
        {
            this.DBContext = DBContext;
        }

        public bool DeletePayment(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("DeletePayment", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Payment> GetPayment()
        {
            IEnumerable<Payment> Result = DBContext.Connection.Query<Payment>("GetPayment", commandType: System.Data.CommandType.StoredProcedure);
            return Result.ToList();
        }

        public bool InsertPayment(Payment Payment)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@CustomerId", Payment.CustomerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@MovieId", Payment.MovieId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@Watched", Payment.Watched, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@VisaCard", Payment.VisaCard, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Value", Payment.Value, dbType: DbType.Double, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("InsertPayment", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdatePayment(Payment Payment)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", Payment.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@CustomerId", Payment.CustomerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@MovieId", Payment.MovieId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@Watched", Payment.Watched, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@VisaCard", Payment.VisaCard, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Value", Payment.Value, dbType: DbType.Double, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("UpdatePayment", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
        public IEnumerable<double> SumOfpayments()
        {
            IEnumerable<double> Result = DBContext.Connection.Query<double>("SumOfPayemnts", commandType: System.Data.CommandType.StoredProcedure);
            return Result;
        }
    }
}
