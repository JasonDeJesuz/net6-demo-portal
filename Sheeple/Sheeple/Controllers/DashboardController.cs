using sheeple.Core.Services.UserAuthenticationService;
using Microsoft.AspNetCore.Mvc;

namespace sheeple.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToActionPermanent("List", "Person");
        }
    }
}
