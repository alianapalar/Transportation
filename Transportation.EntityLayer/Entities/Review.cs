using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.EntityLayer.Entities
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int? ReservationId { get; set; }
        public Reservation Reservation { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public int UserId { get; set; }
        public AppUser User { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
