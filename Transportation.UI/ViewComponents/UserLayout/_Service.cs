using Microsoft.AspNetCore.Mvc;
using Transportation.BusinessLayer.Contracts;

namespace Transportation.UI.ViewComponents.UserLayout
{
    public class _Service:ViewComponent
    {
        private readonly IServiceManager _manager;

        public _Service(IServiceManager manager)
        {
            _manager = manager;
        }

        public IViewComponentResult Invoke()
        {
            var values = _manager.RequestTypeService.GetAllRequestTypes();
            return View(values);
        }
    }
}
