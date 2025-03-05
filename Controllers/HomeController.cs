using Microsoft.AspNetCore.Mvc;

namespace CalmAndConnect.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Doctors()
        {
            return View();
        }

        public IActionResult Blogs()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult WriteBlog()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }

    }
}
