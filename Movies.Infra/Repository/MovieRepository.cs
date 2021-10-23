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
    public class MovieRepository : IMovieRepository
    {
        private readonly IDBContext DBContext;
        public MovieRepository(IDBContext DBContext)
        {
            this.DBContext = DBContext;
        }
        public bool DeleteMovie(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("DeleteMovie", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Movie> GetMovie()
        {
            IEnumerable<Movie> Result = DBContext.Connection.Query<Movie>("GetMovie", commandType: System.Data.CommandType.StoredProcedure);
            return Result.ToList();
        }

        public bool InsertMovie(Movie Movie)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Name", Movie.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@CategoryId", Movie.CategoryId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@Language", Movie.Language, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@StoryLine", Movie.StoryLine, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Img", Movie.Img, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@TrailerUrl", Movie.TrailerUrl, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Video", Movie.Video, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Country", Movie.Country, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@ReleaseDate", Movie.ReleaseDate, dbType: DbType.Date, direction: ParameterDirection.Input);
            parameters.Add("@Price", Movie.Price, dbType: DbType.Double, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("InsertMovie", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateMovie(Movie Movie)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", Movie.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@Name", Movie.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@CategoryId", Movie.CategoryId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@Language", Movie.Language, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@StoryLine", Movie.StoryLine, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Img", Movie.Img, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@TrailerUrl", Movie.TrailerUrl, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Video", Movie.Video, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Country", Movie.Country, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@ReleaseDate", Movie.ReleaseDate, dbType: DbType.Date, direction: ParameterDirection.Input);
            parameters.Add("@Price", Movie.Price, dbType: DbType.Double, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("UpdateMovie", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
        public IEnumerable<double> MaxMoviePrice()
        {
            IEnumerable<double> Result = DBContext.Connection.Query<double>("MaxMoviePrice", commandType: CommandType.StoredProcedure);
            return Result;
        }
        public IEnumerable<double> MinMoviePrice()
        {
            IEnumerable<double> Result = DBContext.Connection.Query<double>("MinMoviePrice", commandType: CommandType.StoredProcedure);
            return Result;
        }
        public List<CustomerListMoviesDTO> CustomerListMovies()
        {
            IEnumerable<CustomerListMoviesDTO> Result = DBContext.Connection.Query<CustomerListMoviesDTO>("CustomerListMovies", commandType: CommandType.StoredProcedure);
            return Result.ToList();
        }
    }
}
