using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ILibrary_BuyBooksOnline.Models
{
    public class ApplicationUser: IdentityUser
    {
        [Required]
        public int Name { get; set; }
        public string? Gender { get; set; }

        public string? StreetAddress { get; set; }
        public string? City { get; set; } = null;
        public string? Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }

    }
}
