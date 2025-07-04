using Microsoft.AspNetCore.Mvc;

namespace asspl.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
