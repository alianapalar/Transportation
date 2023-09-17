using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.EntityLayer.Entities;

namespace Transportation.DataAccessLayer.Contracts
{
    public interface IVehicleRepository:IRepositoryBase<Vehicle>
    {
        List<Vehicle> GetAllVehicles();
        Vehicle GetDriverByVehicleId(int vehicleId);
    }
}
