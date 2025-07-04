using Microsoft.AspNetCore.Mvc;

namespace asspl.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
