using Microsoft.AspNetCore.Mvc;

namespace Transportation.UI.ViewComponents.UserLayout
{
    public class _Carousel:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
