using Microsoft.AspNetCore.Mvc;

namespace Transportation.UI.ViewComponents.UserLayout
{
    public class _Fact:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
