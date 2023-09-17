using Microsoft.AspNetCore.Mvc;
using Transportation.BusinessLayer.Contracts;

namespace Transportation.UI.ViewComponents.UserLayout
{
    public class _Testimonial:ViewComponent
    {
        private readonly IServiceManager _manager;

        public _Testimonial(IServiceManager manager)
        {
            _manager = manager;
        }

        public IViewComponentResult Invoke()
        {
            var values = _manager.ReviewService.GetAllReviews();
            return View(values);
        }
    }
}
