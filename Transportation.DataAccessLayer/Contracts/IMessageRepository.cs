using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.EntityLayer.Entities;

namespace Transportation.DataAccessLayer.Contracts
{
    public interface IMessageRepository : IRepositoryBase<Message>
    {
        List<Message> GetAllMessage();
        void CreateMessage(Message message);
        void UpdateMessage(Message message);
        void DeleteMessage(Message message);
        Message? GetMessageById(int id);
        List<Message> GetSendMessagesById(int id);
        List<Message> GetReceiveMessagesById(int id);

    }
}
