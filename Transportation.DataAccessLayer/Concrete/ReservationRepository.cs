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
    public class ReservationRepository : RepositoryBase<Reservation>, IReservationRepository
    {
        public ReservationRepository(TransportationContext context) : base(context)
        {
        }

        public void CreateReservation(Reservation reservation)
        {
            Create(reservation);
        }

        public void DeleteReservation(Reservation reservation)
        {
            Delete(reservation);
        }

        public List<Reservation> GetAllReservation()
        {
            return _context.Reservations.Include(r => r.Driver).Include(r => r.Vehicle).Include(r => r.TransportTeam).ThenInclude(r=>r.TeamMembers).Include(r => r.TransportRequest).ThenInclude(r=>r.Request).ToList();
        }

        

        public Reservation GetReservationById(int id)
        {
            return _context.Reservations.Where(r => r.ReservationId.Equals(id)).SingleOrDefault();
        }

        public void UpdateReservation(Reservation reservation)
        {
            Update(reservation);
        }
    }
}
