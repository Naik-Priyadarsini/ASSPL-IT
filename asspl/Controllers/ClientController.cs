using Microsoft.AspNetCore.Mvc;

namespace asspl.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
