using Microsoft.AspNetCore.Mvc;

namespace Transportation.UI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
