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
    public class TestimonialRepository : ITestimonialRepository
    {
        private readonly IDBContext DBContext;
        public TestimonialRepository(IDBContext DBContext)
        {
            this.DBContext = DBContext;
        }
        public bool DeleteTestimonial(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("DeleteTestimonial", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Testimonial> GetActiveTestimonial()
        {
            IEnumerable<Testimonial> Result = DBContext.Connection.Query<Testimonial>("GetActiveTestimonial", commandType: System.Data.CommandType.StoredProcedure);
            return Result.ToList();
        }

        public List<Testimonial> GetTestimonial()
        {
            IEnumerable<Testimonial> Result = DBContext.Connection.Query<Testimonial>("GetTestimonial", commandType: System.Data.CommandType.StoredProcedure);
            return Result.ToList();
        }

        public bool InsertTestimonial(Testimonial Testimonial)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@CustomerId", Testimonial.CustomerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@Message", Testimonial.Message, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Stars", Testimonial.Stars, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@IsActive", Testimonial.IsActive, dbType: DbType.Int32, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("InsertTestimonial", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateTestimonial(Testimonial Testimonial)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", Testimonial.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@CustomerId", Testimonial.CustomerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@Message", Testimonial.Message, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Stars", Testimonial.Stars, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@IsActive", Testimonial.IsActive, dbType: DbType.Int32, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("UpdateTestimonial", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
