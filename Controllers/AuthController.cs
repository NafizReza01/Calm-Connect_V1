using Microsoft.AspNetCore.Mvc;

namespace CalmAndConnect.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult PatientLogIn()
        {
            return View();
        }

        public IActionResult PatientSignUp()
        {
            return View();
        }

        public IActionResult DoctorLogIn()
        {
            return View();
        }

        public IActionResult DoctorSignUp()
        {
            return View();
        }
    }
}

