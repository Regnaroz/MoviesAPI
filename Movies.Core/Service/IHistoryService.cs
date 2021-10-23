using Movies.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Core.Service
{
   public  interface IHistoryService
    {
        public List<History> GetHistory();
        public bool InsertHistory(History Histo);
        public bool UpdateHistory(History Histo);
        public bool DeleteHistory(int id);
        public List<History> GetHistoryByCustomerId(int customerId);
    }
}
