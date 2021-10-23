using Movies.Core.Data;
using Movies.Core.Repository;
using Movies.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Infra.Service
{
    public class WorkingHoursService : IWorkingHoursService
    {
        private readonly IWorkingHoursRepository WorkingHoursRepository;
        public WorkingHoursService(IWorkingHoursRepository WorkingHoursRepository)
        {
            this.WorkingHoursRepository = WorkingHoursRepository;
        }
        public bool DeleteWorkingHours(int id)
        {
            return WorkingHoursRepository.DeleteWorkingHours(id);
        }

        public List<WorkingHours> GetWorkingHours()
        {
            return WorkingHoursRepository.GetWorkingHours();
        }

        public bool InsertWorkingHours(WorkingHours WorkingHours)
        {
            return WorkingHoursRepository.InsertWorkingHours(WorkingHours);
        }

        public bool UpdateWorkingHours(WorkingHours WorkingHours)
        {
            return WorkingHoursRepository.UpdateWorkingHours(WorkingHours);
        }
    }
}
