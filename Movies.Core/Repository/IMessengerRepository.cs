using Movies.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Core.Repository
{
   public interface IMessengerRepository
    {
        public List<Messenger> GetMessenger();
        public bool InsertMessenger(Messenger Messenger);
        public bool UpdateMessenger(Messenger Messenger);
        public bool DeleteMessenger(int id);
        public List<Messenger> GetMessengerByCustomerId(int customerId);
    }
}
