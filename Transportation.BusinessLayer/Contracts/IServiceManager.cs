using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.DataAccessLayer.Contracts;

namespace Transportation.BusinessLayer.Contracts
{
    public interface IServiceManager
    {
        IMessageService MessageService { get; }
        IReviewService ReviewService { get; }
        IDriverService DriverService { get; }
        IReservationService ReservationService { get; }
        ITransportRequestService TransportRequestService { get; }
        IRequestTypeService RequestTypeService { get; }
        ITeamMemberService TeamMemberService { get; }
        ITransportTeamService TransportTeamService { get; }
        IVehicleService VehicleService { get; }
    }
}
