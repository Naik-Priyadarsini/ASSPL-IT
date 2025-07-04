using Microsoft.AspNetCore.Mvc;

namespace asspl.Controllers
{
    public class CareerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
