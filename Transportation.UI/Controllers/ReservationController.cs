using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using Transportation.BusinessLayer.Contracts;
using Transportation.EntityLayer.Entities;

namespace Transportation.UI.Controllers
{
    public class ReservationController : Controller
    {
        private readonly IServiceManager _manager;
       
        public ReservationController(IServiceManager manager)
        {
            _manager = manager;
            
        }
        
        
        public  IActionResult CreateReservation([FromQuery]int transportRequestId)
        {
            ViewBag.reservations = _manager.ReservationService.GetAllReservation();
            ViewBag.reviews = _manager.ReviewService.GetAllReviews();
           
            ViewBag.teams = GetTeamMemberByTeam();
            ViewBag.requestId = transportRequestId;
            ViewBag.vehicle = GetVehicles();
            ViewBag.drivers = GetDrivers();
            ViewBag.team = _manager.TransportTeamService.GetAllTransportTeams();
          
            return View();
            
        }
       private List<SelectListItem> GetTeamMemberByTeam()
        {
            var teams=_manager.TransportTeamService.GetAllTransportTeams();
            var teamList=new List<SelectListItem>();
            foreach(var team in teams)
            {
                foreach (var member in team.TeamMembers)
                {
                    teamList.Add(new SelectListItem
                    {
                        Value = member.TransportTeamId.ToString(),
                        Text = $"{member.TransportTeam.TeamName}-{member.Name}"
                    });
                }
            }
            return teamList;
            
        }
        private List<SelectListItem> GetVehicles()
        {
            var vehicles=_manager.VehicleService.GetAllVehicles();
            var vehicleList = new List<SelectListItem>();
            foreach (var item in vehicles)
            {
                vehicleList.Add(new SelectListItem
                {
                    Value = item.VehicleId.ToString(),
                    Text = $"{item.VehicleType}-{item.VehicleInfo}"
                });
            }
            return vehicleList;
        }
        private List<SelectListItem> GetDrivers()
        {
            var drivers=_manager.DriverService.GetAllDrivers();
            var driverList = new List<SelectListItem>();
            foreach (var item in drivers)
            {
                driverList.Add(new SelectListItem
                {
                    Value = item.DriverId.ToString(),
                    Text = $"{item.DriverName}-{item.Description}"
                });
            }
            return driverList;
        }
        [HttpPost]
        public IActionResult CreateReservation(Reservation model)
        {
            
            _manager.ReservationService.CreateReservation(model);
            return RedirectToAction("Index", "Default");

        }
       
    }
}
