using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CalmnConnect.Data;
using CalmnConnect.Models;

namespace CalmnConnect.Views.Auth
{
    public class DoctorSignUpModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DoctorSignUpModel(ApplicationDbContext context)
        {
            _context = context;
            Doctor = new Doctor
            {
                Email = string.Empty,
                FirstName = string.Empty,
                LastName = string.Empty,
                Degrees = string.Empty,
                Availability = new List<Availability>()
            };
        }

        [BindProperty]
        public Doctor Doctor { get; set; }

        public void OnGet()
        {
            ViewData["Title"] = "Doctor Sign Up";
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Doctors.Add(Doctor);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Index");
        }
    }
}
