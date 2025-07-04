using Microsoft.AspNetCore.Mvc;

namespace asspl.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult WebDevelopment() => View();
        public IActionResult MobileApps() => View();
        public IActionResult EnterpriseSolutions() => View();
    }
}
   