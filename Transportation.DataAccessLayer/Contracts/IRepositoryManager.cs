using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.DataAccessLayer.Contracts
{
    public interface IRepositoryManager
    {
        IMessageRepository MessageRepository { get; }
        IReviewRepository ReviewRepository { get; }
        IReservationRepository ReservationRepository { get; }
        ITransportRequestRepository TransportRequestRepository { get; }
        IRequestTypeRepository RequestTypeRepository { get; }
        IDriverRepository DriverRepository { get; }
        ITeamMemberRepository TeamMemberRepository { get; }
        ITransportTeamRepository TransportTeamRepository { get; }
        IVehicleRepository VehicleRepository { get; }
        void Save();
    }
}
