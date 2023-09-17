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
    public class TransportRequestRepository : RepositoryBase<TransportRequest>, ITransportRequestRepository
    {
        public TransportRequestRepository(TransportationContext context) : base(context)
        {
        }

        public List<TransportRequest> ApprovedAllRequest()
        {
            return _context.TransportRequests.Where(t=>t.Status==TransportStatus.Onaylandı).Include(t=>t.Request).ToList();
        }

        public List<TransportRequest> ApprovedRequest(int id)
        {
            return _context.TransportRequests.Where(t => t.Status == TransportStatus.Onaylandı&&t.UserId.Equals(id)).Include(t => t.Request).ToList();
        }

        public void ChangeRequestStatus(int id)
        {
            var request = _context.TransportRequests.Find(id);
            request.Status = TransportStatus.Onaylandı;
            
        }

        public List<TransportRequest> CompletedAllRequest()
        {
            return _context.TransportRequests.Where(t => t.Status == TransportStatus.Tamamlandı).Include(t => t.Request).ToList();
        }

        public List<TransportRequest> CompletedRequest(int id)
        {
            return _context.TransportRequests.Where(t => t.Status == TransportStatus.Tamamlandı && t.UserId.Equals(id)).Include(t => t.Request).Include(t=>t.Reservation).ToList();
        }

        public void CompleteRequestStatus(int id)
        {
            var request=_context.TransportRequests.Find(id);
            request.Status = TransportStatus.Tamamlandı;
        }

        public void CreateRequest(TransportRequest request) => Create(request);
        

        public void DeleteRequest(TransportRequest request)=>Delete(request);


        public List<TransportRequest> GetAllRequest() => GetAll();

       

        public TransportRequest? GetRequestById(int id)
        {
            return FindByCondition(r=>r.TransportRequestId.Equals(id));
        }

        public List<TransportRequest> PendingAllRequest()
        {
            return _context.TransportRequests.Where(t => t.Status == TransportStatus.Bekliyor).Include(t=>t.Request).ToList();
        }

        public List<TransportRequest> PendingRequest(int id)
        {
            return _context.TransportRequests.Where(t=>t.Status==TransportStatus.Bekliyor&& t.UserId.Equals(id)).Include(t=>t.Request).ToList();
        }

        public void UpdateRequest(TransportRequest request)=>Update(request);
       
    }
}
