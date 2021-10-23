using Dapper;
using Movies.Core.Common;
using Movies.Core.Data;
using Movies.Core.DTO;
using Movies.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Movies.Infra.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private readonly IDBContext DBContext;
        public LoginRepository(IDBContext DBContext)
        {
            this.DBContext = DBContext;
        }
        public bool DeleteLogin(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("DeleteLogin", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public string GetCustomerEmail(string userName)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@UserName", userName, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<string> Result = DBContext.Connection.Query<string>("GetCustomerEmail", commandType: System.Data.CommandType.StoredProcedure);
            return Result.FirstOrDefault();
        }

        public List<Login> GetLogin()
        {
            IEnumerable<Login> Result = DBContext.Connection.Query<Login>("GetLogin", commandType: System.Data.CommandType.StoredProcedure);
            return Result.ToList();
        }

        public bool InsertLogin(Login log)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@userName", log.UserName, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@password", log.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@departmentId", log.DepartmentId, dbType: DbType.Int32, direction: ParameterDirection.Input);           
            parameters.Add("@accountantId", log.AccountantId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@customerId", log.CustomerId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            try
            {
                DBContext.Connection.Execute("InsertLogin", parameters, commandType: CommandType.StoredProcedure);

                return true;
            }
            catch (Exception)
            {

                return false;
            }
           
        }

        public Login isUserExist(LoginDTO login)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@UserName", login.UserName, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Password", login.Password, dbType: DbType.String, direction: ParameterDirection.Input);


            IEnumerable<Login> Result = DBContext.Connection.Query<Login>("isUserExist", parameters, commandType: System.Data.CommandType.StoredProcedure);
            return Result.FirstOrDefault();
        }

        public bool IsVertificationExist(NameVerificationDTO verificationDTO)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@vertification", verificationDTO.vertification, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@UserName", verificationDTO.userName, dbType: DbType.String, direction: ParameterDirection.Input);

            IEnumerable<Login> Result = DBContext.Connection.Query<Login>("IsVertificationExist", parameters, commandType: System.Data.CommandType.StoredProcedure);
            if(Result.FirstOrDefault() == null)
            {
                return false;
            }
            return true;
        }

        public bool ResetPassword(LoginDTO login)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@UserName", login.UserName, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Password", login.Password, dbType: DbType.String, direction: ParameterDirection.Input);

            DBContext.Connection.ExecuteAsync("ResetPassword", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateLogin(Login log)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", log.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@UserName", log.UserName, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Password", log.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@DepartmentId", log.DepartmentId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@AccountantId", log.AccountantId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@CustomerId", log.CustomerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("UpdateLogin", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateVertification(NameVerificationDTO verificationDTO)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@verification", verificationDTO.vertification, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@UserName", verificationDTO.userName, dbType: DbType.String, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("UpdateVertification", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
