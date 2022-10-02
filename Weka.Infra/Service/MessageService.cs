using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;
using Weka.Core.Repository;
using Weka.Core.Service;

namespace Weka.Infra.Service
{
    public class MessageService : IMessageService
    {
        private readonly IMessageRepository _messageRepository;
        public MessageService(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }


        public bool CreateMessage(Message message)
        {
            return _messageRepository.CreateMessage(message);
        }

        public bool DeleteMessage(int id)
        {
            return _messageRepository.DeleteMessage(id);
        }

        public List<Message> GetAllMessage()
        {
            return _messageRepository.GetAllMessage();
        }
    }
}
