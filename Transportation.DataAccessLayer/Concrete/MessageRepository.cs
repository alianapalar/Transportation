using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.DataAccessLayer.Context;
using Transportation.DataAccessLayer.Contracts;
using Transportation.EntityLayer.Entities;

namespace Transportation.DataAccessLayer.Concrete
{
    public class MessageRepository : RepositoryBase<Message>, IMessageRepository
    {
        public MessageRepository(TransportationContext context) : base(context)
        {
        }

        public void CreateMessage(Message message) => Create(message);
        

        public void DeleteMessage(Message message)=>Delete(message);


        public List<Message> GetAllMessage() => GetAll();
        

        public Message? GetMessageById(int id)
        {
           return FindByCondition(m=>m.MessageId.Equals(id));
        }

        public List<Message> GetReceiveMessagesById(int id)
        {
            return _context.Messages.Where(i=>i.ReceiverUserId.Equals(id)).Include(i=>i.ReceiverUser).ToList();
        }

        public List<Message> GetSendMessagesById(int id)
        {
            return _context.Messages.Where(i => i.SenderUserId.Equals(id)).Include(i => i.SenderUser).ToList();
        }

        public void UpdateMessage(Message message)=>Update(message);
        
    }
}
