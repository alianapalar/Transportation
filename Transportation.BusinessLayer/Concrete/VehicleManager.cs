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
    public class VehicleManager:IVehicleService
    {
        private readonly IRepositoryManager _manager;

        public VehicleManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public List<Vehicle> GetAllVehicles()
        {
            return _manager.VehicleRepository.GetAllVehicles();
        }

        public Vehicle GetDriverByVehicleId(int vehicleId)
        {
            return _manager.VehicleRepository.GetDriverByVehicleId(vehicleId);
        }
    }
}
