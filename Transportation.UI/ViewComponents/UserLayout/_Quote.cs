using Microsoft.AspNetCore.Mvc;

namespace Transportation.UI.ViewComponents.UserLayout
{
    public class _Quote:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
