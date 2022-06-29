using Microsoft.AspNetCore.Mvc;

namespace web_assignment2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult contact()
        {
            return View();
        }
    }
}
