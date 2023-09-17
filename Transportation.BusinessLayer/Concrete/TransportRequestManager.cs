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
    public class TransportRequestManager:ITransportRequestService
    {
        private readonly IRepositoryManager _manager;

        public TransportRequestManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public List<TransportRequest> ApprovedAllRequest()
        {
            return _manager.TransportRequestRepository.ApprovedAllRequest();
        }

        public List<TransportRequest> ApprovedRequest(int id)
        {
            return _manager.TransportRequestRepository.ApprovedRequest(id);
        }

        public void ChangeRequestStatus(int id)
        {
             _manager.TransportRequestRepository.ChangeRequestStatus(id);
            _manager.Save();
        }

        public List<TransportRequest> CompletedAllRequest()
        {
            return _manager.TransportRequestRepository.CompletedAllRequest();
        }

        public List<TransportRequest> CompletedRequest(int id)
        {
            return _manager.TransportRequestRepository.CompletedRequest(id);
        }

        public void CompleteRequestStatus(int id)
        {
            _manager.TransportRequestRepository.CompleteRequestStatus(id);
            _manager.Save();
        }

        public void CreateRequest(TransportRequest request)
        {
            _manager.TransportRequestRepository.CreateRequest(request);
            _manager.Save();
        }

        public void DeleteRequest(TransportRequest request)
        {
            _manager.TransportRequestRepository.DeleteRequest(request);
            _manager.Save();
        }

        public List<TransportRequest> GetAllRequest()
        {
            return _manager.TransportRequestRepository.GetAllRequest();
        }

        public TransportRequest? GetRequestById(int id)
        {
            return _manager.TransportRequestRepository.GetRequestById(id);
        }

        public List<TransportRequest> PendingAllRequest()
        {
            return _manager.TransportRequestRepository.PendingAllRequest();
        }

        public List<TransportRequest> PendingRequest(int id)
        {
            return _manager.TransportRequestRepository.PendingRequest(id);
        }

        public void UpdateRequest(TransportRequest request)
        {
            _manager.TransportRequestRepository.UpdateRequest(request);
            _manager.Save();
        }
    }
}
