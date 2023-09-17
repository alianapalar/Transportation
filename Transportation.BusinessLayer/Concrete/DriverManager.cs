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
    public class DriverManager:IDriverService
    {
        private readonly IRepositoryManager _manager;

        public DriverManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public List<Driver> GetAllDrivers()
        {
            return _manager.DriverRepository.GetAllDrivers();
        }
    }
}
