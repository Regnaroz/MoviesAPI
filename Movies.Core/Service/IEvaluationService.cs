using Movies.Core.Data;
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
    }
}
