using Microsoft.AspNetCore.Mvc;

namespace Transportation.UI.ViewComponents.UserLayout
{
    public class _Feature:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
