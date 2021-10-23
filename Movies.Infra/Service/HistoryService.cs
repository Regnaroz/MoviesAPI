using Movies.Core.Data;
using Movies.Core.Repository;
using Movies.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Infra.Service
{
    public class HistoryService: IHistoryService
    {
        private readonly IHistoryRepository HistoryRepository;
        public HistoryService(IHistoryRepository HistoryRepository)
        {
            this.HistoryRepository = HistoryRepository;
        }
        public bool DeleteHistory(int id)
        {
            return HistoryRepository.DeleteHistory(id);
        }
        public List<History> GetHistory()
        {
            return HistoryRepository.GetHistory();
        }

        public List<History> GetHistoryByCustomerId(int customerId)
        {
            return HistoryRepository.GetHistoryByCustomerId(customerId);
        }

        public bool InsertHistory(History Histo)
        {
            return HistoryRepository.InsertHistory(Histo);
        }
        public bool UpdateHistory(History Histo)
        {
            return HistoryRepository.UpdateHistory(Histo);
        }
    }
}
