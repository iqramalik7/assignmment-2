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
            ViewBag.message = "LOGIN";
            return View();
        }

        public IActionResult formm(string fname, string lname, string email, double phoneno, string gender, string dep, string textbox)
        {
            if(fname != null && lname != null && email != null && phoneno != null && gender != null && dep != null && textbox != null)
            {
                ViewBag.message = "Successfull";
            }
            else
            {
                ViewBag.message = "Failed";
            }
            return View("contact");
        }
    }
}
