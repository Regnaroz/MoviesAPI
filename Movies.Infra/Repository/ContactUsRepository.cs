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
    public class ContactUsRepository : IContactUsRepository
    {
        private readonly IDBContext DBContext;
        public ContactUsRepository(IDBContext DBContext)
        {
            this.DBContext = DBContext;
        }
        public bool DeleteContactUs(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("DeleteContactUs", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<ContactUs> GetContactUs()
        {
            IEnumerable<ContactUs> Result = DBContext.Connection.Query<ContactUs>("GetContactUs", commandType: System.Data.CommandType.StoredProcedure);
            return Result.ToList();
        }

        public bool InsertContactUs(ContactUs ContactUs)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Name", ContactUs.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Phone", ContactUs.Phone, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Email", ContactUs.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Message", ContactUs.Message, dbType: DbType.String, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("InsertContactUs", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateContactUs(ContactUs ContactUs)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", ContactUs.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@Name", ContactUs.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Phone", ContactUs.Phone, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Email", ContactUs.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Message", ContactUs.Message, dbType: DbType.String, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("UpdateContactUs", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
