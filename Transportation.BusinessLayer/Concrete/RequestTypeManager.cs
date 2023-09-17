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
    public class RequestTypeManager:IRequestTypeService
    {
        private readonly IRepositoryManager _manager;
        public RequestTypeManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public List<RequestType> GetAllRequestTypes()
        {
           return _manager.RequestTypeRepository.GetAllRequestTypes();
        }
    }
}
