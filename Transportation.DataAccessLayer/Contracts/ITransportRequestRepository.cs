using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.EntityLayer.Entities;

namespace Transportation.DataAccessLayer.Contracts
{
    public interface ITransportRequestRepository : IRepositoryBase<TransportRequest>
    {
        void CreateRequest(TransportRequest request);
        void DeleteRequest(TransportRequest request);
        void UpdateRequest(TransportRequest request);
        List<TransportRequest> GetAllRequest();
        List<TransportRequest> PendingRequest(int id);
        List<TransportRequest> PendingAllRequest();
        List<TransportRequest> ApprovedRequest(int id);
        List<TransportRequest> ApprovedAllRequest();
        List<TransportRequest> CompletedAllRequest();
        List<TransportRequest> CompletedRequest(int id);
        TransportRequest? GetRequestById(int id);
        void ChangeRequestStatus(int id);
        void CompleteRequestStatus(int id);
    }
}
