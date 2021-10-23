using Movies.Core.Data;
using Movies.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Core.Repository
{
    public interface IMovieRepository
    {
        public List<Movie> GetMovie();
        public bool InsertMovie(Movie Movie);
        public bool UpdateMovie(Movie Movie);
        public bool DeleteMovie(int id);
        public IEnumerable<double> MaxMoviePrice();
        public IEnumerable<double> MinMoviePrice();
        public List<CustomerListMoviesDTO> CustomerListMovies();
    }
}
