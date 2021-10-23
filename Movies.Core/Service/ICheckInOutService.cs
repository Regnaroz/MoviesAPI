using Movies.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Core.Service
{
    public interface ICheckInOutService
    {
        public List<CheckInOut> GetCheckInOut();
        public bool InsertCheckInOut(CheckInOut checkInOut);
        public bool UpdateCheckInOut(CheckInOut checkInOut);
        public bool DeleteCheckInOut(int id);
    }
}
