using Microsoft.AspNetCore.Mvc;

namespace asspl.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
