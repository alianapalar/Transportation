using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.EntityLayer.Entities;

namespace Transportation.DataAccessLayer.Contracts
{
    public interface IRequestTypeRepository:IRepositoryBase<RequestType>
    {
        List<RequestType> GetAllRequestTypes();
    }
}
