using CalmnConnect.Data;
using CalmnConnect.Views.Auth;
using Microsoft.AspNetCore.Mvc;

namespace CalmAndConnect.Controllers
{
    public class AuthController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AuthController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult PatientLogIn()
        {
            return View();
        }

        public IActionResult PatientSignUp()
        {
            var model = new PatientSignUpModel(_context);
            return View(model);
        }

        public IActionResult DoctorLogIn()
        {
            return View();
        }

        public IActionResult DoctorSignUp()
        {
            var model = new DoctorSignUpModel(_context); // Pass the context to the model
            return View(model); // Pass the model to the view
        }
    }
}

