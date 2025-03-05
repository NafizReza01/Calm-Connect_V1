using Microsoft.AspNetCore.Mvc;

namespace CalmAndConnect.Controllers
{
    public class AppointmentsController : Controller
    {
        public IActionResult Anonymous()
        {
            return View();
        }

        public IActionResult Online()
        {
            return View();
        }

        public IActionResult Offline()
        {
            return View();
        }
    }
}

