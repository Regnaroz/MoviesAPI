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
    public class EvaluationController : Controller
    {
        private readonly IEvaluationService EvaluationService;
        public EvaluationController(IEvaluationService EvaluationService)
        {
            this.EvaluationService = EvaluationService;
        }
        [ProducesResponseType(typeof(List<Evaluation>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Evaluation), StatusCodes.Status400BadRequest)]
        [HttpGet]
        [Route("GetEvaluation")]//sub route
        public List<Evaluation> GetEvaluation()
        {
            return EvaluationService.GetEvaluation();
        }
        [ProducesResponseType(typeof(List<Evaluation>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Evaluation), StatusCodes.Status400BadRequest)]
        [HttpPost]
        [Route("InsertEvaluation")]//sub route
        public bool InsertEvaluation([FromBody] Evaluation Evaluation)
        {
            return EvaluationService.InsertEvaluation(Evaluation);
        }
        [ProducesResponseType(typeof(List<Evaluation>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Evaluation), StatusCodes.Status400BadRequest)]
        [HttpDelete]
        [Route("DeleteEvaluation/{id}")]//sub route
        public bool DeleteEvaluation(int id)
        {
            return EvaluationService.DeleteEvaluation(id);
        }
        [ProducesResponseType(typeof(List<Evaluation>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Evaluation), StatusCodes.Status400BadRequest)]
        [HttpPut]
        [Route("UpdateEvaluation")]//sub route
        public bool UpdateEvaluation([FromBody] Evaluation Evaluation)
        {
            return EvaluationService.UpdateEvaluation(Evaluation);
        }
        [ProducesResponseType(typeof(List<Evaluation>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Evaluation), StatusCodes.Status400BadRequest)]
        [HttpGet]
        [Route("GetMoviesEvaluation")]//sub route
        public List<GetMoviesEvaluationDTO> GetMoviesEvaluation()
        {
            return EvaluationService.GetMoviesEvaluation();
        }
        [ProducesResponseType(typeof(List<Evaluation>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Evaluation), StatusCodes.Status400BadRequest)]
        [HttpGet]
        [Route("IsCustomerRated/{customerId}/{movieId}")]
        public bool IsCustomerRated(int customerId, int movieId)
        {
            if (EvaluationService.IsCustomerRated(customerId, movieId) != null)
            {
                return true;
            }
            return false;
        }
    }
}
