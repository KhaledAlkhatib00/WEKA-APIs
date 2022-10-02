using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;

namespace Weka.Core.Repository
{
    public interface IMessageRepository
    {
        bool CreateMessage(Message message);
        List<Message> GetAllMessage();
        bool DeleteMessage(int id);
    }
}
