using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.EntityLayer.Entities
{
    public class TransportRequest
    {
        public int TransportRequestId { get; set; }
        public int? RequestTypeId { get; set; }
        public RequestType Request { get; set; }
        public int UserId { get; set; }
        public AppUser User { get; set; }
        public DateTime CreatedAt { get; set; }
        public TransportStatus Status{ get; set; }
        public int? ReservationId { get; set; }
        public Reservation Reservation { get; set; }
    }
    public enum TransportStatus
{
    Bekliyor=0,
    Onaylandı=1,
    Tamamlandı=2
}
}
