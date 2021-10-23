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
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IDBContext dBContext;
        public CustomerRepository(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public bool DeleteCustomer(int id)
        {
            var paramteres = new DynamicParameters();
            paramteres.Add("@Id", id, dbType: DbType.Int64, direction: ParameterDirection.Input);

            var Result = dBContext.Connection.ExecuteAsync("DeleteCustomer", paramteres, commandType: CommandType.StoredProcedure);

            return true;
        }

        public List<Customer> GetCustomer()
        {
            IEnumerable<Customer> Result = dBContext.Connection.Query<Customer>("GetCustomer", commandType: CommandType.StoredProcedure);
            return Result.ToList();
        }

        public bool InsertCustomer(Customer customer)
        {
            var paramteres = new DynamicParameters();
            paramteres.Add("@firstName", customer.FirstName, dbType: DbType.String, direction: ParameterDirection.Input);
            paramteres.Add("@lastName", customer.LastName, dbType: DbType.String, direction: ParameterDirection.Input);
            paramteres.Add("@phone", customer.Phone, dbType: DbType.String, direction: ParameterDirection.Input);
            paramteres.Add("@email", customer.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            paramteres.Add("@gender", customer.Gender, dbType: DbType.String, direction: ParameterDirection.Input);
            paramteres.Add("@wallet", customer.Wallet, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            paramteres.Add("@visaCard", customer.VisaCard, dbType: DbType.String, direction: ParameterDirection.Input);
            paramteres.Add("@img", customer.Img, dbType: DbType.String, direction: ParameterDirection.Input);

            try
            {
                var Result = dBContext.Connection.Execute("InsertCustomer", paramteres, commandType: CommandType.StoredProcedure);
                return true;          
            }
            catch (Exception)
            {

                return false;
            }
           
        }

        public bool UpdateCustomer(Customer customer)
        {
            var paramteres = new DynamicParameters();
            paramteres.Add("@Id", customer.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            paramteres.Add("@firstName", customer.FirstName, dbType: DbType.String, direction: ParameterDirection.Input);
            paramteres.Add("@lastName", customer.LastName, dbType: DbType.String, direction: ParameterDirection.Input);
            paramteres.Add("@phone", customer.Phone, dbType: DbType.String, direction: ParameterDirection.Input);
            paramteres.Add("@email", customer.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            paramteres.Add("@gender", customer.Gender, dbType: DbType.String, direction: ParameterDirection.Input);
            paramteres.Add("@wallet", customer.Wallet, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            paramteres.Add("@visaCard", customer.VisaCard, dbType: DbType.String, direction: ParameterDirection.Input);
            paramteres.Add("@img", customer.Img, dbType: DbType.String, direction: ParameterDirection.Input);

            var Result = dBContext.Connection.Execute("UpdateCustomer", paramteres, commandType: CommandType.StoredProcedure);

            return true;
        }
    }
}
