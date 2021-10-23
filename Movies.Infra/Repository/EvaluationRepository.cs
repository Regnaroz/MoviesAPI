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
    public class EvaluationRepository : IEvaluationRepository
    {
        private readonly IDBContext DBContext;
        public EvaluationRepository(IDBContext DBContext)
        {
            this.DBContext = DBContext;
        }
        public bool DeleteEvaluation(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("DeleteEvaluation", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Evaluation> GetEvaluation()
        {
            IEnumerable<Evaluation> Result = DBContext.Connection.Query<Evaluation>("GetEvaluation", commandType: System.Data.CommandType.StoredProcedure);
            return Result.ToList();
        }

        public bool InsertEvaluation(Evaluation Evaluation)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@CustomerId", Evaluation.CustomerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@MovieId", Evaluation.MovieId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@Stars", Evaluation.Stars, dbType: DbType.Int32, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("InsertEvaluation", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateEvaluation(Evaluation Evaluation)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", Evaluation.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@CustomerId", Evaluation.CustomerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@MovieId", Evaluation.MovieId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@Stars", Evaluation.Stars, dbType: DbType.Int32, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("UpdateEvaluation", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
