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
    public class VehicleRepository : RepositoryBase<Vehicle>, IVehicleRepository
    {
        public VehicleRepository(TransportationContext context) : base(context)
        {
        }

        public List<Vehicle> GetAllVehicles()
        {
            return _context.Vehicles.Include(v=>v.Driver).ToList();
        }

        public Vehicle GetDriverByVehicleId(int vehicleId)
        {
            return _context.Vehicles.Include(v => v.Driver).Where(v => v.VehicleId.Equals(vehicleId)).SingleOrDefault();
        }
    }
}
