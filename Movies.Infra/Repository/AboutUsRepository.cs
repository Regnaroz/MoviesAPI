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
    public class AboutUsRepository : IAboutUsRepository
    {
        private readonly IDBContext dBContext;
        public AboutUsRepository(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public bool DeleteAboutUs(int id)
        {
            var paramteres = new DynamicParameters();
            paramteres.Add("@Id", id, dbType: DbType.Int64, direction: ParameterDirection.Input);

            var Result = dBContext.Connection.ExecuteAsync("DeleteAboutUs", paramteres, commandType: CommandType.StoredProcedure);

            return true;
        }

        public List<AboutUs> GetAboutUs()
        {
            IEnumerable<AboutUs> Result = dBContext.Connection.Query<AboutUs>("GetAboutUs", commandType: CommandType.StoredProcedure);
            return Result.ToList();
        }

        public bool InsertAboutUs(AboutUs aboutUs)
        {
            var paramteres = new DynamicParameters();
            paramteres.Add("@title", aboutUs.Title, dbType: DbType.String, direction: ParameterDirection.Input);
            paramteres.Add("@subTitle", aboutUs.SubTitle, dbType: DbType.String, direction: ParameterDirection.Input);
            paramteres.Add("@paragraph1", aboutUs.Paragraph1, dbType: DbType.String, direction: ParameterDirection.Input);
            paramteres.Add("@paragraph2", aboutUs.Paragraph2, dbType: DbType.String, direction: ParameterDirection.Input);
            paramteres.Add("@img1", aboutUs.Img1, dbType: DbType.String, direction: ParameterDirection.Input);
            paramteres.Add("@img2", aboutUs.Img2, dbType: DbType.String, direction: ParameterDirection.Input);

            var Result = dBContext.Connection.ExecuteAsync("InsertAboutUs", paramteres, commandType: CommandType.StoredProcedure);

            return true;
        }

        public bool UpdateCourse(AboutUs aboutUs)
        {
            var paramteres = new DynamicParameters();
            paramteres.Add("@Id", aboutUs.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            paramteres.Add("@title", aboutUs.Title, dbType: DbType.String, direction: ParameterDirection.Input);
            paramteres.Add("@subTitle", aboutUs.SubTitle, dbType: DbType.String, direction: ParameterDirection.Input);
            paramteres.Add("@paragraph1", aboutUs.Paragraph1, dbType: DbType.String, direction: ParameterDirection.Input);
            paramteres.Add("@paragraph2", aboutUs.Paragraph2, dbType: DbType.String, direction: ParameterDirection.Input);
            paramteres.Add("@img1", aboutUs.Img1, dbType: DbType.String, direction: ParameterDirection.Input);
            paramteres.Add("@img2", aboutUs.Img2, dbType: DbType.String, direction: ParameterDirection.Input);

            var Result = dBContext.Connection.ExecuteAsync("InsertAboutUs", paramteres, commandType: CommandType.StoredProcedure);

            return true;
        }
    }
}
