using Microsoft.AspNetCore.Mvc;
using Transportation.BusinessLayer.Contracts;

namespace Transportation.UI.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceManager _manager;

        public ServiceController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            var values = _manager.RequestTypeService.GetAllRequestTypes();
            return View(values);
        }
        public IActionResult Vehicle()
        {
            var values = _manager.VehicleService.GetAllVehicles();
            return View(values);
        }
        public IActionResult Driver()
        {
            var values = _manager.DriverService.GetAllDrivers();
            return View(values);
        }
    }
}
