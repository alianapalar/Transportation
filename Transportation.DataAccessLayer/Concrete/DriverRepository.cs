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
    public class DriverRepository : RepositoryBase<Driver>, IDriverRepository
    {
        public DriverRepository(TransportationContext context) : base(context)
        {
        }

        public List<Driver> GetAllDrivers()
        {
            return _context.Drivers.ToList();
        }

       
    }
}
