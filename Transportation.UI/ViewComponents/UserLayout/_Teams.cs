using Microsoft.AspNetCore.Mvc;
using Transportation.BusinessLayer.Contracts;

namespace Transportation.UI.ViewComponents.UserLayout
{
    public class _Teams:ViewComponent
    {
        private readonly IServiceManager _manager;

        public _Teams(IServiceManager manager)
        {
            _manager = manager;
        }

        public IViewComponentResult Invoke()
        {
            var values = _manager.TeamMemberService.GetAllTeamMembers();
            return View(values);  
        }
    }
}
