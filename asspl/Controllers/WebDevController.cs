using Microsoft.AspNetCore.Mvc;

namespace asspl.Controllers
{
    public class WebDevController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
