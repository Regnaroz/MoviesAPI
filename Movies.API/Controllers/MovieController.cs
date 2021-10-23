using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movies.Core.Data;
using Movies.Core.DTO;
using Movies.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : Controller
    {
        private readonly IMovieService MovieService;
        public MovieController(IMovieService MovieService)
        {
            this.MovieService = MovieService;
        }
        [ProducesResponseType(typeof(List<Movie>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Movie), StatusCodes.Status400BadRequest)]
        [HttpGet]
        [Route("GetMovie")]//sub route
        public List<Movie> GetMovie()
        {
            return MovieService.GetMovie();
        }
        [ProducesResponseType(typeof(List<Movie>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Movie), StatusCodes.Status400BadRequest)]
        [HttpPost]
        [Route("InsertMovie")]//sub route
        public bool InsertMovie([FromBody] Movie Movie)
        {
            return MovieService.InsertMovie(Movie);
        }
        [ProducesResponseType(typeof(List<Movie>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Movie), StatusCodes.Status400BadRequest)]
        [HttpDelete]
        [Route("DeleteMovie/{id}")]//sub route
        public bool DeleteMovie(int id)
        {
            return MovieService.DeleteMovie(id);
        }
        [ProducesResponseType(typeof(List<Movie>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Movie), StatusCodes.Status400BadRequest)]
        [HttpPut]
        [Route("UpdateMovie")]//sub route
        public bool UpdateMovie([FromBody] Movie Movie)
        {
            return MovieService.UpdateMovie(Movie);
        }
        [ProducesResponseType(typeof(List<Movie>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Movie), StatusCodes.Status400BadRequest)]
        [HttpGet]
        [Route("MaxMoviePrice")]//sub route
        public IEnumerable<double> MaxMoviePrice()
        {
            return MovieService.MaxMoviePrice();

        }
        [ProducesResponseType(typeof(List<Movie>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Movie), StatusCodes.Status400BadRequest)]
        [HttpGet]
        [Route("MinMoviePrice")]//sub route
        public IEnumerable<double> MinMoviePrice()
        {
            return MovieService.MinMoviePrice();

        }
        [ProducesResponseType(typeof(List<CustomerListMoviesDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CustomerListMoviesDTO), StatusCodes.Status400BadRequest)]
        [HttpGet]
        [Route("CustomerListMovies")]//sub route
        public List<CustomerListMoviesDTO> CustomerListMovies()
        {
            return MovieService.CustomerListMovies();
        }
    }
}
