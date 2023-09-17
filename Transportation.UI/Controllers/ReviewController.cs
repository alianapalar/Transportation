using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Transportation.BusinessLayer.Contracts;
using Transportation.EntityLayer.Entities;

namespace Transportation.UI.Controllers
{
    public class ReviewController : Controller
    {
        private readonly IServiceManager _manager;
        private readonly UserManager<AppUser> _userManager;

        public ReviewController(IServiceManager manager, UserManager<AppUser> userManager)
        {
            _manager = manager;
            _userManager = userManager;
        }

        public async Task<IActionResult> CreateReview([FromQuery] int reservationId)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userId = user.Id;
            ViewBag.reservation = reservationId;
            return View();
        }
        [HttpPost]
        public IActionResult CreateReview(Review model)
        {
            model.CreatedAt = DateTime.Now;
            _manager.ReviewService.CreateReview(model);
            return RedirectToAction("Index", "Default");
        }
    }
}
