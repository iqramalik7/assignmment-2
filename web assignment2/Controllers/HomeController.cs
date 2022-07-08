using Microsoft.AspNetCore.Mvc;
using web_assignment2.Data;
using web_assignment2.Models;

namespace web_assignment2.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _context;
        private DataContext _write;

        public IActionResult Index()
        {
            return View();
        }

        public HomeController(DataContext context)
        {
            _context = context;
            _write = context;
        }

        public IActionResult contact()
        {
            ViewBag.message = "LOGIN";
            return View();
        }
        [HttpPost]
        public IActionResult formm(Customerinfo s)
        {
            _write.Customerinfo.Add(s);
            _write.SaveChanges();
            return View("contact");
        }

        public IActionResult table()
        {
            return View(_context.Customerinfo.ToList());
        }
    }
}
