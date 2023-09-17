using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Transportation.BusinessLayer.Contracts;
using Transportation.EntityLayer.Entities;

namespace Transportation.UI.Controllers
{
    public class MessageController : Controller
    {
        private readonly IServiceManager _manager;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        public MessageController(IServiceManager manager, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _manager = manager;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult SendMessage()
        {
            
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SendMessage(Message model)
        {
            var senderUser = await _userManager.FindByNameAsync(User.Identity.Name);
            var receiverUser = await _roleManager.FindByNameAsync("Admin");
            model.SenderUserId = senderUser.Id;
            model.SentAt = DateTime.UtcNow;
            model.ReceiverUserId = receiverUser.Id;
            _manager.MessageService.CreateMessage(model);
            return RedirectToAction("Index", "Default");
        }
        public async Task<IActionResult> ListSendMessage()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var values = _manager.MessageService.GetSendMessagesById(user.Id);
            return View(values);
        }
        public async Task<IActionResult> ListReceiveMessage()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var values=_manager.MessageService.GetReceiveMessagesById(user.Id);
            return View(values);
        }
        public async Task<ActionResult> RepliedMessage([FromQuery] int receiverId)
        {
            ViewBag.receiver = receiverId;
            var sender = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.sender = sender.Id;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RepliedMessage(Message model)
        {
            
            
            model.SentAt= DateTime.UtcNow;
            
            _manager.MessageService.CreateMessage(model);
            return RedirectToAction("Index", "Default");
        }
    }
}
