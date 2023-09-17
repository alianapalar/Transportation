using Microsoft.AspNetCore.Mvc;

namespace Transportation.UI.ViewComponents.UserLayout
{
    public class _Pricing:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
