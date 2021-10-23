using Movies.Core.Data;
using Movies.Core.DTO;
using Movies.Core.Repository;
using Movies.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Infra.Service
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository MovieRepository;
        public MovieService(IMovieRepository MovieRepository)
        {
            this.MovieRepository = MovieRepository;
        }
        public bool DeleteMovie(int id)
        {
            return MovieRepository.DeleteMovie(id);
        }

        public List<Movie> GetMovie()
        {
            return MovieRepository.GetMovie();
        }

        public bool InsertMovie(Movie Movie)
        {
            return MovieRepository.InsertMovie(Movie);
        }

        public bool UpdateMovie(Movie Movie)
        {
            return MovieRepository.UpdateMovie(Movie);
        }
        public IEnumerable<double> MaxMoviePrice()
        {
            return MovieRepository.MaxMoviePrice();
        }
        public IEnumerable<double> MinMoviePrice()
        {
            return MovieRepository.MinMoviePrice();
        }
        public List<CustomerListMoviesDTO> CustomerListMovies()
        {
            return MovieRepository.CustomerListMovies();
        }
    }
}
