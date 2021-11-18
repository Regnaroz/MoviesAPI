using Movies.Core.Data;
using Movies.Core.DTO;
using Movies.Core.Repository;
using Movies.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Infra.Service
{
    public class EvaluationService : IEvaluationService
    {
        private readonly IEvaluationRepository EvaluationRepository;
        public EvaluationService(IEvaluationRepository EvaluationRepository)
        {
            this.EvaluationRepository = EvaluationRepository;
        }
        public bool DeleteEvaluation(int id)
        {
            return EvaluationRepository.DeleteEvaluation(id);
        }

        public List<Evaluation> GetEvaluation()
        {
            return EvaluationRepository.GetEvaluation();
        }

        public bool InsertEvaluation(Evaluation Evaluation)
        {
            return EvaluationRepository.InsertEvaluation(Evaluation);
        }

        public bool UpdateEvaluation(Evaluation Evaluation)
        {
            return EvaluationRepository.UpdateEvaluation(Evaluation);
        }
        public List<GetMoviesEvaluationDTO> GetMoviesEvaluation()
        {
            return EvaluationRepository.GetMoviesEvaluation();
        }
        public Evaluation IsCustomerRated(int customerId, int movieId)
        {
            return EvaluationRepository.IsCustomerRated(customerId, movieId);
        }

    }
}
