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
    public class ReservationManager:IReservationService
    {
        private readonly IRepositoryManager _manager;

        public ReservationManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public void CreateReservation(Reservation reservation)
        {
            _manager.ReservationRepository.CreateReservation(reservation);
            _manager.Save();
        }

        public void DeleteReservation(Reservation reservation)
        {
            _manager.ReservationRepository.DeleteReservation(reservation);
            _manager.Save();
        }

        public List<Reservation> GetAllReservation()
        {
            return _manager.ReservationRepository.GetAllReservation();
        }

        public Reservation GetReservationById(int id)
        {
            return _manager.ReservationRepository.GetReservationById(id);
        }

        public void UpdateReservation(Reservation reservation)
        {
            _manager.ReservationRepository.UpdateReservation(reservation);
            _manager.Save();
        }
    }
}
