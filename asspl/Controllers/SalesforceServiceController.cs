using Microsoft.AspNetCore.Mvc;

namespace asspl.Controllers
{
    public class SalesforceServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
