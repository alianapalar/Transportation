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
    public class RequestTypeRepository : RepositoryBase<RequestType>, IRequestTypeRepository
    {
        public RequestTypeRepository(TransportationContext context) : base(context)
        {
        }

        public List<RequestType> GetAllRequestTypes()
        {
            return _context.RequestTypes.ToList();
        }
    }
}
