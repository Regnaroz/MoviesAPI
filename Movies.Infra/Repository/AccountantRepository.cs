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
    public class AccountantRepository : IAccountantRepository
    {
        private readonly IDBContext dBContext;
        public AccountantRepository(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public bool DeleteAccountant(int id)
        {
            var paramteres = new DynamicParameters();
            paramteres.Add("@Id", id, dbType: DbType.Int64, direction: ParameterDirection.Input);

            var Result = dBContext.Connection.ExecuteAsync("DeleteAccountant", paramteres, commandType: CommandType.StoredProcedure);

            return true;
        }

        public List<Accountant> GetAccountant()
        {
            IEnumerable<Accountant> Result = dBContext.Connection.Query<Accountant>("GetAccountant", commandType: CommandType.StoredProcedure);
            return Result.ToList();
        }

        public bool InsertAccountant(Accountant accountant)
        {
            var paramteres = new DynamicParameters();
            paramteres.Add("@firstName", accountant.FirstName, dbType: DbType.String, direction: ParameterDirection.Input);
            paramteres.Add("@lastName", accountant.LastName, dbType: DbType.String, direction: ParameterDirection.Input);
            paramteres.Add("@phone", accountant.Phone, dbType: DbType.String, direction: ParameterDirection.Input);
            paramteres.Add("@email", accountant.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            paramteres.Add("@gender", accountant.Gender, dbType: DbType.String, direction: ParameterDirection.Input);
            paramteres.Add("@wallet", accountant.Wallet, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            paramteres.Add("@salary", accountant.Salary, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            paramteres.Add("@img", accountant.Img, dbType: DbType.String, direction: ParameterDirection.Input);

            var Result = dBContext.Connection.ExecuteAsync("InsertAccountant", paramteres, commandType: CommandType.StoredProcedure);

            return true;
        }

        public bool UpdateAccountant(Accountant accountant)
        {
            var paramteres = new DynamicParameters();
            paramteres.Add("@Id", accountant.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            paramteres.Add("@firstName", accountant.FirstName, dbType: DbType.String, direction: ParameterDirection.Input);
            paramteres.Add("@lastName", accountant.LastName, dbType: DbType.String, direction: ParameterDirection.Input);
            paramteres.Add("@phone", accountant.Phone, dbType: DbType.String, direction: ParameterDirection.Input);
            paramteres.Add("@email", accountant.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            paramteres.Add("@gender", accountant.Gender, dbType: DbType.String, direction: ParameterDirection.Input);
            paramteres.Add("@wallet", accountant.Wallet, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            paramteres.Add("@salary", accountant.Salary, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            paramteres.Add("@img", accountant.Img, dbType: DbType.String, direction: ParameterDirection.Input);

            var Result = dBContext.Connection.ExecuteAsync("UpdateAccountant", paramteres, commandType: CommandType.StoredProcedure);

            return true;
        }
    }
}
