using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CalmnConnect.Models
{
    public class Doctor : IdentityUser
    {
        [Required]
        public required string FirstName { get; set; }

        [Required]
        public required string LastName { get; set; }

        [Required]
        public required string Degrees { get; set; }

        public required List<Availability> Availability { get; set; }
    }

    public class Availability
    {
        public int Id { get; set; }
        public required string Day { get; set; }
        public required List<TimeSlot> Times { get; set; }
    }

    public class TimeSlot
    {
        public int Id { get; set; }
        public required string From { get; set; }
        public required string To { get; set; }
        public required string Place { get; set; }
    }
}
