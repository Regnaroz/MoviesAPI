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
    public class WebSiteRepository : IWebSiteRepository
    {
        private readonly IDBContext DBContext;
        public WebSiteRepository(IDBContext DBContext)
        {
            this.DBContext = DBContext;
        }
        public bool DeleteWebSite(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("DeleteWebSite", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<WebSite> GetWebSite()
        {
            IEnumerable<WebSite> Result = DBContext.Connection.Query<WebSite>("GetWebSite", commandType: System.Data.CommandType.StoredProcedure);
            return Result.ToList();
        }

        public bool InsertWebSite(WebSite WebSite)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@LogoImg", WebSite.LogoImg, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Name", WebSite.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Phone", WebSite.Phone, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Email", WebSite.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("InsertWebSite", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateWebSite(WebSite WebSite)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", WebSite.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@LogoImg", WebSite.LogoImg, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Name", WebSite.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Phone", WebSite.Phone, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Email", WebSite.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("UpdateWebSite", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
