using Microsoft.AspNetCore.Mvc;

namespace CalmnConnect.Controllers
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

        [HttpPost]
        public IActionResult Offline(string name, string date, string location)
        {
            // You can process the form data here (e.g., save to a database)
            ViewData["Message"] = $"Appointment booked for {name} on {date} at {location}.";

            return View();
        }
    } // Add this closing brace to properly terminate the class
}
