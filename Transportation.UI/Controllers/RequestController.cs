using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Transportation.BusinessLayer.Contracts;
using Transportation.EntityLayer.Entities;

namespace Transportation.UI.Controllers
{
    public class RequestController : Controller
    {
        private readonly IServiceManager _manager;
        private readonly UserManager<AppUser> _userManager;

        public RequestController(IServiceManager manager, UserManager<AppUser> userManager)
        {
            _manager = manager;
            _userManager = userManager;
        }

        public async Task<IActionResult> CreateRequest()
        {
            var user =await _userManager.FindByNameAsync(User.Identity.Name);
            
            ViewBag.user = user.Id;
            ViewBag.requestTypes = GetRequestTypeList();
            return View();
        }
        private SelectList GetRequestTypeList()
        {
            return new SelectList(_manager.RequestTypeService.GetAllRequestTypes(), "RequestTypeId", "RequestName", "1");
        }
        [HttpPost]
        public IActionResult CreateRequest(TransportRequest model)
        {
            model.CreatedAt= DateTime.Now;
            _manager.TransportRequestService.CreateRequest(model);
            return RedirectToAction("PendingRequest","Request");
        }
        public async Task<IActionResult> PendingRequest()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var values=_manager.TransportRequestService.PendingRequest(user.Id);
            return View(values);
        }
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> PendingAllRequest()
        {
            var values = _manager.TransportRequestService.PendingAllRequest();
            return View(values);
        }
        public async Task<IActionResult> ApprovedRequest()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var values=_manager.TransportRequestService.ApprovedRequest(user.Id);
            return View(values);
        }
        public IActionResult ApprovedAllRequest()
        {
            var values = _manager.TransportRequestService.ApprovedAllRequest();
            return View(values);
        }
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> ConfirmRequest(int id)
        {
            _manager.TransportRequestService.ChangeRequestStatus(id);
            return RedirectToAction("ApprovedAllRequest", "Request");
        }
        [Authorize(Roles ="Admin")]
        public IActionResult CompleteRequest(int id)
        {
            _manager.TransportRequestService.CompleteRequestStatus(id);
            return RedirectToAction("CompletedAllRequest", "Request");
        }
        public async Task<IActionResult> CompletedRequest()
        {
            var user=await _userManager.FindByNameAsync(User.Identity.Name);
            var values = _manager.TransportRequestService.CompletedRequest(user.Id);
            return View(values);
        }
        public IActionResult CompletedAllRequest()
        {
            var values = _manager.TransportRequestService.CompletedAllRequest();
            return View(values);
        }
    }
}
