using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.BusinessLayer.Contracts;
using Transportation.DataAccessLayer.Contracts;

namespace Transportation.BusinessLayer.Concrete
{
    public class ServiceManager:IServiceManager
    {
        private readonly IMessageService _messageService;
        private readonly IReviewService _reviewService;
        private readonly IDriverService _driverService;
        private readonly ITeamMemberService _teamMemberService;
        private readonly ITransportTeamService _transportTeamService;
        private readonly IVehicleService _vehicleService;
        private readonly ITransportRequestService _transportRequestService;
        private readonly IRequestTypeService _requestTypeService;
        private readonly IReservationService _reservationService;


        public ServiceManager(IMessageService messageService,
            IReviewService reviewService, IDriverService driverService,
            ITeamMemberService teamMemberService,
            ITransportTeamService transportTeamService,
            IVehicleService vehicleService,
            ITransportRequestService transportRequestService,
            IRequestTypeService requestTypeService, IReservationService reservationService)
        {
            _messageService = messageService;
            _reviewService = reviewService;
            _driverService = driverService;
            _teamMemberService = teamMemberService;
            _transportTeamService = transportTeamService;
            _vehicleService = vehicleService;
            _transportRequestService = transportRequestService;
            _requestTypeService = requestTypeService;
            _reservationService = reservationService;
        }

        public IMessageService MessageService => _messageService;

        public IReviewService ReviewService => _reviewService;

        

        public ITransportRequestService TransportRequestService => _transportRequestService;

        public IRequestTypeService RequestTypeService => _requestTypeService;

        public IDriverService DriverService => _driverService;

        public ITeamMemberService TeamMemberService => _teamMemberService;

        public ITransportTeamService TransportTeamService => _transportTeamService;

        public IVehicleService VehicleService => _vehicleService;

        public IReservationService ReservationService => _reservationService;
    }
}
