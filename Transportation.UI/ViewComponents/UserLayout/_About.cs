using Microsoft.AspNetCore.Mvc;

namespace Transportation.UI.ViewComponents.UserLayout
{
    public class _About : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
