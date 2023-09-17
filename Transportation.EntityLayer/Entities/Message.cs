using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.EntityLayer.Entities
{
    public class Message
    {
        public int MessageId { get; set; }
        public string Content { get; set; }
        public DateTime SentAt { get; set; }
        public int? SenderUserId { get; set; }
        public int? ReceiverUserId { get; set; }
        public AppUser SenderUser { get; set; }
        public AppUser ReceiverUser { get; set; }

    }
}
