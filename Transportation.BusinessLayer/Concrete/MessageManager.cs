using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.BusinessLayer.Contracts;
using Transportation.DataAccessLayer.Contracts;
using Transportation.EntityLayer.Entities;

namespace Transportation.BusinessLayer.Concrete
{
    public class MessageManager:IMessageService
    {
        private readonly IRepositoryManager _manager;

        public MessageManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public void CreateMessage(Message message)
        {
            _manager.MessageRepository.CreateMessage(message);
            _manager.Save();
        }

        public void DeleteMessage(Message message)
        {
            _manager.MessageRepository.DeleteMessage(message);
            _manager.Save();
        }

        public List<Message> GetAllMessage()
        {
          return _manager.MessageRepository.GetAllMessage();
        }

        public Message? GetMessageById(int id)
        {
           return _manager.MessageRepository.GetMessageById(id);
        }

        public List<Message> GetReceiveMessagesById(int id)
        {
            return _manager.MessageRepository.GetReceiveMessagesById(id);
        }

        public List<Message> GetSendMessagesById(int id)
        {
            return _manager.MessageRepository.GetSendMessagesById(id);
        }

        public void UpdateMessage(Message message)
        {
            _manager.MessageRepository.UpdateMessage(message);
            _manager.Save();
        }
    }
}
