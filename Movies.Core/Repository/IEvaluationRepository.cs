using Movies.Core.Data;
using Movies.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Core.Repository
{
    public interface IEvaluationRepository
    {
        public List<Evaluation> GetEvaluation();
        public bool InsertEvaluation(Evaluation Evaluation);
        public bool UpdateEvaluation(Evaluation Evaluation);
        public bool DeleteEvaluation(int id);
        public List<GetMoviesEvaluationDTO> GetMoviesEvaluation();

    }
}
