// Data/ApplicationDbContext.cs
using Microsoft.EntityFrameworkCore;
using CalmnConnect.Models;

namespace CalmnConnect.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Availability> Availabilities { get; set; }
        public DbSet<TimeSlot> TimeSlots { get; set; }
    }
}
