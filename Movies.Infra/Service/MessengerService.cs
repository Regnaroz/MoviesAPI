using Movies.Core.Data;
using Movies.Core.Repository;
using Movies.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Infra.Service
{
    public class MessengerService: IMessengerService
    {
        private readonly IMessengerRepository MessengerRepository;
        public MessengerService(IMessengerRepository MessengerRepository)
        {
            this.MessengerRepository = MessengerRepository;
        }
        public bool DeleteMessenger(int id)
        {
            return MessengerRepository.DeleteMessenger(id);
        }
        public List<Messenger> GetMessenger()
        {
            return MessengerRepository.GetMessenger();
        }

        public List<Messenger> GetMessengerByCustomerId(int customerId)
        {
            return MessengerRepository.GetMessengerByCustomerId(customerId);
        }

        public bool InsertMessenger(Messenger Messenger)
        {
            return MessengerRepository.InsertMessenger(Messenger);
        }
        public bool UpdateMessenger(Messenger Messenger)
        {
            return MessengerRepository.UpdateMessenger(Messenger);
        }
    }
}
