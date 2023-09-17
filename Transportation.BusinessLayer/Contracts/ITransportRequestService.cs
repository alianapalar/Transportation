using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.EntityLayer.Entities;

namespace Transportation.BusinessLayer.Contracts
{
    public interface ITransportRequestService
    {
        void CreateRequest(TransportRequest request);
        void DeleteRequest(TransportRequest request);
        void UpdateRequest(TransportRequest request);
        List<TransportRequest> GetAllRequest();
        List<TransportRequest> PendingRequest(int id);
        List<TransportRequest> PendingAllRequest();
        List<TransportRequest> ApprovedRequest(int id);
        List<TransportRequest> ApprovedAllRequest();
        TransportRequest? GetRequestById(int id);
        List<TransportRequest> CompletedAllRequest();
        List<TransportRequest> CompletedRequest(int id);
        void ChangeRequestStatus(int id);
        void CompleteRequestStatus(int id);
    }
}
