using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movies.Core.Data;
using Movies.Core.DTO;
using Movies.Core.Service;
using System;
using System.Collections.Generic;
using System.IO;

namespace Movies.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : Controller
    {
        private readonly IMovieService MovieService;
        private readonly IEvaluationService evaluationService;
        public MovieController(IMovieService MovieService, IEvaluationService evaluationService)
        {
            this.MovieService = MovieService;
            this.evaluationService = evaluationService;
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
        [ProducesResponseType(typeof(List<CustomerListMoviesDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CustomerListMoviesDTO), StatusCodes.Status400BadRequest)]
        [HttpGet]
        [Route("GetCatMovie")]//sub route
        public List<MovieCatDto> GetCatMovie()
        {
            return MovieService.GetCatMovie();
        }
        [ProducesResponseType(typeof(List<Movie>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Movie), StatusCodes.Status400BadRequest)]
        [HttpGet]
        [Route("GetMovieByID/{Id}")]//sub route
        public MovieDetailsDTO GetMovieByID(int Id)
        {
            return MovieService.GetMovieByID(Id);
        }
        [ProducesResponseType(typeof(List<Movie>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Movie), StatusCodes.Status400BadRequest)]
        [HttpGet]
        [Route("GetMoviesEval")]//sub route
        public List<MoviesEvalDTO> GetMoviesEval()
        {
            List<MoviesEvalDTO> moviesEval = new List<MoviesEvalDTO>();
            List<Movie> movies = MovieService.GetMovie();
            List<Evaluation> evaluations = evaluationService.GetEvaluation();

            foreach (var mov in movies)
            {

                double sum = 0;
                double likes = 0;
                foreach (var eval in evaluations)
                {
                    if (mov.Id == eval.MovieId)
                    {
                        sum++;
                        if (eval.Stars == 1)
                        {
                            likes++;
                        }
                    }

                }
                MoviesEvalDTO movies1 = new MoviesEvalDTO();
                movies1.Id = mov.Id;
                if (sum != 0)
                {
                    movies1.Eval = (likes / sum) * 100;
                }
                else { movies1.Eval = 0; }

                moviesEval.Add(movies1);
            }
            return moviesEval;
        }


        [Route("uploadVideoImage")]
        [HttpPost]
        public Customer UploadIMage()
        {
            try
            {
                var file = Request.Form.Files[0];
                byte[] fileContent;
                using (var ms = new MemoryStream())
                {
                    file.CopyTo(ms);
                    fileContent = ms.ToArray();
                }
                var fileName = Path.GetFileNameWithoutExtension(file.FileName);


                //decoder for image name , no duplicate errors
                string attachmentFileName = $"{fileName}.{Path.GetExtension(file.FileName).Replace(".", "")}";
                //path for angualr project file
                var fullPath = Path.Combine("C:\\Users\\lenovo\\AngualrNew-811\\moviesAngular\\src\\assets\\" +
                "images\\movies-images", attachmentFileName);
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                Customer item = new Customer();
                item.Img = attachmentFileName;


                return item;
            }
            catch (Exception e)
            {
                return null;
            }
        }



        [Route("uploadVideo")]
        [HttpPost]
        public Customer UploadVideo()
        {
            try
            {
                var file = Request.Form.Files[0];
                byte[] fileContent;
                using (var ms = new MemoryStream())
                {
                    file.CopyTo(ms);
                    fileContent = ms.ToArray();
                }
                var fileName = Path.GetFileNameWithoutExtension(file.FileName);


                //decoder for image name , no duplicate errors
                string attachmentFileName = $"{fileName}.{Path.GetExtension(file.FileName).Replace(".", "")}";
                //path for angualr project file
                var fullPath = Path.Combine("C:\\Users\\lenovo\\AngualrNew-811\\moviesAngular\\src\\assets\\" +
                "Videos", attachmentFileName);
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                Customer item = new Customer();
                item.Img = attachmentFileName;


                return item;
            }
            catch (Exception e)
            {
                return null;
            }
        }


    }
}
