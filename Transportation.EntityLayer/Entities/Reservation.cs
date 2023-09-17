using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.EntityLayer.Entities
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int TransportRequestId { get; set; }
        public TransportRequest TransportRequest { get; set; }
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
        public int DriverId { get; set; }
        public Driver Driver { get; set; }
        public int TransportTeamId { get; set; }
        public TransportTeam TransportTeam { get; set; }
    }
}
