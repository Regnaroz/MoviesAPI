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
    public class CommentsRepository : ICommentsRepository
    {
        private readonly IDBContext dBContext;
        public CommentsRepository(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public bool DeleteComments(int id)
        {
            var paramteres = new DynamicParameters();
            paramteres.Add("@Id", id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var Result = dBContext.Connection.ExecuteAsync("DeleteComments", paramteres, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Comments> GetComments()
        {
            IEnumerable<Comments> Result = dBContext.Connection.Query<Comments>("GetComments", commandType: CommandType.StoredProcedure);
            return Result.ToList();
        }

        public bool InsertComments(Comments comments)
        {
            var paramteres = new DynamicParameters();
            paramteres.Add("@customerId", comments.CustomerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            paramteres.Add("@movieId", comments.MovieId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            paramteres.Add("@message", comments.Message, dbType: DbType.String, direction: ParameterDirection.Input);
            paramteres.Add("@time", comments.Time, dbType: DbType.DateTime, direction: ParameterDirection.Input);


            var Result = dBContext.Connection.ExecuteAsync("InsertComments", paramteres, commandType: CommandType.StoredProcedure);

            return true;
        }

        public bool UpdateComments(Comments comments)
        {
            var paramteres = new DynamicParameters();
            paramteres.Add("@Id", comments.CustomerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            paramteres.Add("@customerId", comments.CustomerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            paramteres.Add("@movieId", comments.MovieId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            paramteres.Add("@message", comments.Message, dbType: DbType.String, direction: ParameterDirection.Input);
            paramteres.Add("@time", comments.Time, dbType: DbType.DateTime, direction: ParameterDirection.Input);


            var Result = dBContext.Connection.ExecuteAsync("UpdateComments", paramteres, commandType: CommandType.StoredProcedure);

            return true;
        }
    }
}
