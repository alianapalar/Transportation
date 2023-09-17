using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.EntityLayer.Entities;

namespace Transportation.BusinessLayer.Contracts
{
    public interface IReservationService
    {
        List<Reservation> GetAllReservation();
        Reservation GetReservationById(int id);
        void CreateReservation(Reservation reservation);
        void UpdateReservation(Reservation reservation);
        void DeleteReservation(Reservation reservation);
    }
}
