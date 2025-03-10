using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CalmnConnect.Data;
using CalmnConnect.Models;
using System.Threading.Tasks;
using BCrypt.Net;

namespace CalmnConnect.Views.Auth
{
    public class PatientSignUpModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public PatientSignUpModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Patient Patient { get; set; } = new Patient();

        public void OnGet()
        {
            ViewData["Title"] = "Patient Sign Up";
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Hash the password before saving
            Patient.Password = BCrypt.Net.BCrypt.HashPassword(Patient.Password);

            _context.Patients.Add(Patient);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Index");
        }
    }
}
