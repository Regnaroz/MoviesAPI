using Movies.Core.Data;
using Movies.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Core.Service
{
    public interface IEvaluationService
    {
        public List<Evaluation> GetEvaluation();
        public bool InsertEvaluation(Evaluation Evaluation);
        public bool UpdateEvaluation(Evaluation Evaluation);
        public bool DeleteEvaluation(int id);
        public List<GetMoviesEvaluationDTO> GetMoviesEvaluation();
        public Evaluation IsCustomerRated(int customerId, int movieId);
    }
}
