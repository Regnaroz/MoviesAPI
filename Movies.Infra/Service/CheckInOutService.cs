using Movies.Core.Data;
using Movies.Core.Repository;
using Movies.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Infra.Service
{
    public class CheckInOutService : ICheckInOutService
    {
        private readonly ICheckInOutRepository checkInOutRepository;
        public CheckInOutService(ICheckInOutRepository checkInOutRepository)
        {
            this.checkInOutRepository = checkInOutRepository;
        }

        public bool DeleteCheckInOut(int id)
        {
            return checkInOutRepository.DeleteCheckInOut(id);
        }

        public List<CheckInOut> GetCheckInOut()
        {
            return checkInOutRepository.GetCheckInOut();
        }

        public bool InsertCheckInOut(CheckInOut checkInOut)
        {
            return checkInOutRepository.InsertCheckInOut(checkInOut);
        }

        public bool UpdateCheckInOut(CheckInOut checkInOut)
        {
            return checkInOutRepository.UpdateCheckInOut(checkInOut);
        }
    }
}
