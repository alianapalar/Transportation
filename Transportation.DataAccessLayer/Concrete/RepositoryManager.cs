using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Transportation.DataAccessLayer.Context;
using Transportation.DataAccessLayer.Contracts;

namespace Transportation.DataAccessLayer.Concrete
{
    public class RepositoryManager:IRepositoryManager
    {
        private readonly TransportationContext _context;
        private readonly IReviewRepository _reviewRepository;
        private readonly IMessageRepository _messageRepository;
        private readonly ITransportRequestRepository _transportRequestRepository;
        private readonly IVehicleRepository _vehicleRepository;
        private readonly ITeamMemberRepository _memberRepository;
        private readonly ITransportTeamRepository _teamRepository;
        private readonly IDriverRepository _driverRepository;
        private readonly IReservationRepository _reservationRepository;
        
        private readonly IRequestTypeRepository _requestTypeRepository;

        public RepositoryManager(TransportationContext context, IReviewRepository reviewRepository,
            IMessageRepository messageRepository,
            ITransportRequestRepository transportRequestRepository,
            IRequestTypeRepository requestTypeRepository,
            IVehicleRepository vehicleRepository,
            ITeamMemberRepository memberRepository,
            ITransportTeamRepository teamRepository,
            IDriverRepository driverRepository, IReservationRepository reservationRepository)
        {
            _context = context;
            _reviewRepository = reviewRepository;
            _messageRepository = messageRepository;
            _transportRequestRepository = transportRequestRepository;
            _teamRepository = teamRepository;
            _driverRepository = driverRepository;
            _memberRepository = memberRepository;
            _vehicleRepository = vehicleRepository;
            _requestTypeRepository = requestTypeRepository;
            _reservationRepository = reservationRepository;
        }

        public IMessageRepository MessageRepository => _messageRepository;

        public IReviewRepository ReviewRepository => _reviewRepository;

        

        public ITransportRequestRepository TransportRequestRepository => _transportRequestRepository;

        public IRequestTypeRepository RequestTypeRepository => _requestTypeRepository;

        public IDriverRepository DriverRepository => _driverRepository;

        public ITeamMemberRepository TeamMemberRepository => _memberRepository;

        public ITransportTeamRepository TransportTeamRepository => _teamRepository;

        public IVehicleRepository VehicleRepository => _vehicleRepository;

        public IReservationRepository ReservationRepository => _reservationRepository;

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
